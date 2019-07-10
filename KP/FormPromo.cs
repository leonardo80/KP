using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KP
{
    public partial class FormPromo : Form
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static DataSet ds;
        public static string sql;
        DateTime dt = DateTime.Now;
        public static string tempnamabarang;
        public bool updating = false;
        public static List<string> listnamabarang = new List<string>();
        public static List<string> listnamapromo = new List<string>();
        public static List<string> isidatagrid = new List<string>();

        public FormPromo()
        {
            InitializeComponent();
        }

        public void activate()
        {
            tbKodeBarang.Enabled = true;cbBarang.Enabled = true;
            tbJumlah.Enabled = true;tbPoin.Enabled = true;tbNamaPromo.Enabled = true;

            btnUpdate.Enabled = false;btnAdd.Enabled = true;btnCancel.Enabled = true;btnSave.Enabled = true;
        }

        public void clearDatagrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void deactivate()
        {
            tbKodeBarang.Enabled = false; cbBarang.Enabled = false;
            tbJumlah.Enabled = false; tbPoin.Enabled = false; tbNamaPromo.Enabled = false;

            btnUpdate.Enabled = false; btnAdd.Enabled = false; btnCancel.Enabled = false; btnSave.Enabled = false;

            cbStart.Enabled = false;cbEnd.Enabled = false;cbYear.Enabled = false;
        }

        public void loadbarang()
        {
            Koneksi.openConn();
            listnamabarang.Clear();
            string stm = "select * from barang order by nama_barang";
            MySqlCommand cmd = new MySqlCommand(stm, Koneksi.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listnamabarang.Add(dr.GetString(1));
            }
            Koneksi.conn.Close();
            cbBarang.Text = "";
            cbBarang.Items.AddRange(listnamabarang.ToArray<string>());
            cbBarang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbBarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public void loadnamapromo()
        {
            Koneksi.openConn();
            listnamapromo.Clear();
            cmd = new MySqlCommand("select nama from promo where status='0'",Koneksi.conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                listnamapromo.Add(dr.GetString(0));
            }
            Koneksi.conn.Close();
            cbSearch.Text = "";
            cbSearch.Items.Clear();
            cbSearch.Items.AddRange(listnamapromo.ToArray<string>());
            cbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public void settingdatagrid()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Nama Barang";
            dataGridView1.Columns[1].Name = "Jumlah";
            dataGridView1.Columns[2].Name = "Kemasan";
            dataGridView1.Columns[3].Name = "Poin";

            DataGridViewColumn col;
            col = dataGridView1.Columns[0]; col.Width = 280;
            col = dataGridView1.Columns[1]; col.Width = 70;
            col = dataGridView1.Columns[2]; col.Width = 70;
            col = dataGridView1.Columns[3]; col.Width = 90;            
        }

        private void FormPromo_Load(object sender, EventArgs e)
        {
            Koneksi.openConn();
            loadnamapromo();
            this.ActiveControl = cbSearch;
            Koneksi.conn.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            activate();loadbarang();
            clearDatagrid();settingdatagrid();
            btnNew.Enabled = false;btnEdit.Enabled = false;
            btnDelete.Enabled = false;btnFind.Enabled = false;
            updating = false;tbIDPromo.Text = "";tbPeriodePromo.Text = "";

            cbSearch.Text = "";cbSearch.Enabled = false;
            cbBarang.Text = "";cbStart.Enabled = true;cbEnd.Enabled = true;


            cbStart.SelectedIndex = Convert.ToInt32(dt.Month.ToString()) - 1;
            cbEnd.SelectedIndex = Convert.ToInt32(dt.Month.ToString()) - 1;

            cbStart.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbStart.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbEnd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEnd.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.ActiveControl = tbNamaPromo;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIDPromo.Text!="")
            {
                activate(); loadbarang();
                string idpromo = tbIDPromo.Text;
                tbNamaPromo.Text = cbSearch.Text;
                isidatagrid.Clear();
                cbSearch.Enabled = false; cbSearch.Text = "";
                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    string nama = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string jumlah = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string kemasan = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string poin = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    isidatagrid.Add(nama + "-" + jumlah + "-" + kemasan + "-" + poin);
                }
                Koneksi.openConn();
                cmd = new MySqlCommand("delete from dpromo where id_promo='"+idpromo+"'",Koneksi.conn);
                cmd.ExecuteNonQuery();
                Koneksi.conn.Close();

                cbStart.Enabled = true;  cbEnd.Enabled = true; cbYear.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDPromo.Text!="")
            {
                DialogResult res = MessageBox.Show("Disabled Promo?","Notice",MessageBoxButtons.YesNo);
                if(res==DialogResult.Yes)
                {
                    Koneksi.openConn();
                    cmd = new MySqlCommand("update promo set status='1' where id_promo='" + tbIDPromo.Text + "'", Koneksi.conn);
                    cmd.ExecuteNonQuery();
                    Koneksi.conn.Close();
                    loadnamapromo();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text.Length == 6)
            {
                this.ActiveControl = cbBarang;
            }
            try
            {
                Koneksi.openConn();
                cmd = new MySqlCommand("select nama_barang,satuan_barang from barang where id_barang='" + tbKodeBarang.Text + "'", Koneksi.conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbBarang.Text = dr.GetString(0);
                    tbKemasan.Text = dr.GetString(1);
                }
                Koneksi.conn.Close();
            }
            catch (Exception x)
            {}
        }

        private void cbBarang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.openConn();
                cmd = new MySqlCommand("select id_barang,satuan_barang from barang where nama_barang='" + cbBarang.Text + "'", Koneksi.conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tbKodeBarang.Text = dr.GetString(0);
                    tbKemasan.Text = dr.GetString(1);
                }
                Koneksi.conn.Close();
            }
            catch (Exception x)
            { }

        }

        private void tbKodeBarang_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            FormBarang.selecttextbox(t);
        }

        private void cbBarang_Enter(object sender, EventArgs e)
        {
            //cbBarang.DroppedDown = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbKodeBarang.Text!="" && tbJumlah.Text!="0" && tbPoin.Text!="0")
            {
                bool found = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString()==cbBarang.Text)
                    {
                        found = true;
                        i = dataGridView1.Rows.Count;
                    }
                }
                if (found==true)
                {
                    MessageBox.Show("Terdapat Barang Yang Sama");
                }
                else
                {
                    if (updating==true)
                    {
                        MessageBox.Show("Anda Sedang Melakukan Update");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(cbBarang.Text, tbJumlah.Text, tbKemasan.Text, tbPoin.Text);
                        this.ActiveControl = tbKodeBarang;
                    }
                }
            }
            else
            {
                MessageBox.Show("Jumlah / Poin Tidak Boleh Kosong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tempnamabarang)
                {
                    index = i;
                }
            }

            if (index != -1)
            {
                dataGridView1.Rows[index].Cells[0].Value = cbBarang.Text;
                dataGridView1.Rows[index].Cells[1].Value = tbJumlah.Text;
                dataGridView1.Rows[index].Cells[2].Value = tbKemasan.Text;
                dataGridView1.Rows[index].Cells[3].Value = tbPoin.Text;
                btnUpdate.Enabled = false;updating = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            deactivate(); clearDatagrid();
            if (tbIDPromo.Text!="")
            {
                for(int i=0;i<isidatagrid.Count;i++)
                {
                    string[] temp = isidatagrid[i].Split('-');
                    dataGridView1.Rows.Add(temp[0], temp[1], temp[2], temp[3]);
                }
                Koneksi.openConn();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("select id_barang from barang where nama_barang='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'", Koneksi.conn);
                    string namabarang = cmd.ExecuteScalar().ToString();
                    cmd = new MySqlCommand("insert into dpromo values('" + tbIDPromo.Text + "','" + namabarang + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "')", Koneksi.conn);
                    cmd.ExecuteNonQuery();
                }
                Koneksi.conn.Close();
                cbSearch.Text = tbNamaPromo.Text;
                tbNamaPromo.Text = "";
                deactivate();
            }
            else
            {
                tbKodeBarang.Text = ""; cbBarang.Text = "";
                tbJumlah.Text = "0"; tbPoin.Text = "0";
                tbIDPromo.Text = ""; tbNamaPromo.Text = "";
                btnNew.Enabled = true; btnEdit.Enabled = true;
                btnDelete.Enabled = true; btnFind.Enabled = true;
                updating = false;
                cbSearch.Enabled = true;
                this.ActiveControl = btnNew;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNamaPromo.Text!="")
            {
                if (tbIDPromo.Text != "")
                {
                    //updating

                    //update periode promo
                    Koneksi.openConn();
                    cmd = new MySqlCommand("update promo set nama='"+tbNamaPromo.Text+"', start='"+cbStart.Text+"', end='"+cbEnd.Text+"', tahun='"+cbYear.Text+"' where id_promo='"+tbIDPromo.Text+"'", Koneksi.conn);
                    cmd.ExecuteNonQuery();
                    Koneksi.conn.Close();

                    Koneksi.openConn();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string namabarang = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string jumlah = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string poin = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        cmd = new MySqlCommand("select id_barang from barang where nama_barang='" + namabarang + "'", Koneksi.conn);
                        string idbarang = cmd.ExecuteScalar().ToString();

                        //insert into dpromo
                        cmd = new MySqlCommand("insert into dpromo values('" + tbIDPromo.Text + "','" + idbarang + "','" + jumlah + "','" + poin + "')", Koneksi.conn);
                        cmd.ExecuteNonQuery();
                    }
                    Koneksi.conn.Close();
                    deactivate(); clearDatagrid();

                    loadnamapromo();

                    tbIDPromo.Text = ""; tbNamaPromo.Text = "";
                    tbKodeBarang.Text = ""; cbBarang.Text = "";
                    tbJumlah.Text = "0"; tbKemasan.Text = ""; tbPoin.Text = "0";tbPeriodePromo.Text = "";

                    btnNew.Enabled = true; btnEdit.Enabled = true;
                    btnFind.Enabled = true; btnDelete.Enabled = true;
                    cbSearch.Enabled = true;

                    cbStart.Text = "";cbEnd.Text = "";cbYear.Text = "";
                }
                else if (dataGridView1.Rows.Count!=0)
                {
                    Koneksi.openConn();
                    cmd = new MySqlCommand("select count(*) from promo",Koneksi.conn);
                    int ctr = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    ctr += 1;
                    Koneksi.conn.Close();

                    //insert into promo
                    Koneksi.openConn();
                    cmd = new MySqlCommand("insert into promo values('" + ctr + "','" + tbNamaPromo.Text + "','"+cbStart.Text+"','"+cbEnd.Text+"','"+dt.Year.ToString()+"','0')", Koneksi.conn);
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string namabarang = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string jumlah = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string poin = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        cmd = new MySqlCommand("select id_barang from barang where nama_barang='" + namabarang + "'", Koneksi.conn);
                        string idbarang = cmd.ExecuteScalar().ToString();

                        //insert into dpromo
                        cmd = new MySqlCommand("insert into dpromo values('" + ctr + "','" + idbarang + "','" + jumlah + "','" + poin + "')", Koneksi.conn);
                        cmd.ExecuteNonQuery();
                    }
                    Koneksi.conn.Close();
                    deactivate(); clearDatagrid();
                    
                    loadnamapromo();

                    tbIDPromo.Text = ""; tbNamaPromo.Text = "";
                    tbKodeBarang.Text = ""; cbBarang.Text = "";
                    tbJumlah.Text = "0"; tbKemasan.Text = ""; tbPoin.Text = "0";

                    btnNew.Enabled = true; btnEdit.Enabled = true;
                    btnFind.Enabled = true; btnDelete.Enabled = true;
                    cbSearch.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("Belum Ada Barang");
                }
            }
            else
            {
                MessageBox.Show("Nama Promo Tidak Boleh Kosong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbJumlah.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbKemasan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbPoin.Text= dataGridView1.Rows[e.RowIndex].Cells
              [3].Value.ToString();
            btnUpdate.Enabled = true; tempnamabarang = cbBarang.Text;
            updating = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tempnamabarang)
                {
                    index = i;
                }
            }
            dataGridView1.Rows.RemoveAt(index);
            dataGridView1.Refresh();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.openConn();
                cmd = new MySqlCommand("select id_promo from promo where nama='" + cbSearch.Text + "' ", Koneksi.conn);
                tbIDPromo.Text = cmd.ExecuteScalar().ToString();
                Koneksi.conn.Close();
                Koneksi.openConn();
                da = new MySqlDataAdapter("select b.nama_barang as \"Nama Barang\", d.jumlah as Jumlah,b.satuan_barang as Satuan ,d.poin as Poin from barang b, dpromo d where d.id_barang=b.id_barang and d.id_promo='"+tbIDPromo.Text+"'", Koneksi.conn);
                ds = new DataSet();
                da.Fill(ds);
                clearDatagrid();
                settingdatagrid();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][1].ToString(), ds.Tables[0].Rows[i][2].ToString(),ds.Tables[0].Rows[i][3].ToString());
                }
                Koneksi.conn.Close();
                Koneksi.openConn();
                cmd = new MySqlCommand("select * from promo where id_promo='"+tbIDPromo.Text+"'",Koneksi.conn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    tbPeriodePromo.Text = dr.GetString(2) + " - " + dr.GetString(3) + ", " + dr.GetString(4);

                    cbStart.Text = dr.GetString(2);
                    cbEnd.Text = dr.GetString(3);
                    cbYear.Text = dr.GetString(4);
                }
                Koneksi.conn.Close();
            }
            catch (Exception x)
            {}
        }

        private void btnDeletedPromo_Click(object sender, EventArgs e)
        {
            DeletedPromo f = new DeletedPromo();
            f.Show();
        }
    }
}
