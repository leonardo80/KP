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
    public partial class FormUpdateHpp : Form
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static DataSet ds;

        public static List<string> listnamabarang = new List<string>();

        public FormUpdateHpp()
        {
            InitializeComponent();
        }
        
        public void loadbarang()
        {
            Koneksi.openConn();
            listnamabarang.Clear();
            string stm = "select nama_barang from barang order by nama_barang";
            cmd = new MySqlCommand(stm, Koneksi.conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listnamabarang.Add(dr.GetString(0));
            }
            Koneksi.conn.Close();
            cbBarang.Text = "";
            cbBarang.Items.AddRange(listnamabarang.ToArray<string>());
            cbBarang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbBarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void FormUpdateHpp_Load(object sender, EventArgs e)
        {
            loadbarang();
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.openConn();
                cmd = new MySqlCommand("select nama_barang from barang where id_barang='"+tbKodeBarang.Text+"'", Koneksi.conn);
                string nama = cmd.ExecuteScalar().ToString();
                cbBarang.Text = nama;
                cmd = new MySqlCommand("select hpp from hpp where id_barang='" + tbKodeBarang.Text + "'", Koneksi.conn);
                tbHpp.Text = cmd.ExecuteScalar().ToString();
                this.ActiveControl = cbBarang;
                Koneksi.conn.Close();
            }
            catch (Exception x)
            {

            }
        }
        

        private void tbJumlah_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            FormBarang.selecttextbox(t);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Koneksi.openConn();
            cmd = new MySqlCommand("update hpp set hpp='"+tbHpp.Text.Replace(".","")+"' where id_barang='"+tbKodeBarang.Text+"'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("select hpp from hpp where id_barang='" + tbKodeBarang.Text + "'", Koneksi.conn);
            tbHpp.Text = Function.separator(cmd.ExecuteScalar().ToString());
            Koneksi.conn.Close();
            MessageBox.Show("Berhasil Update");
        }

        private void tbHpp_TextChanged(object sender, EventArgs e)
        {
            if (tbHpp.Text != "")
            {
                tbHpp.Text = Function.separator(tbHpp.Text);
                tbHpp.SelectionStart = tbHpp.TextLength;
                tbHpp.SelectionLength = 0;
            }
        }

        private void cbBarang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.openConn();
                cmd = new MySqlCommand("select id_barang from barang where nama_barang='" + cbBarang.Text + "'", Koneksi.conn);
                string nama = cmd.ExecuteScalar().ToString();
                tbKodeBarang.Text = nama;
                cmd = new MySqlCommand("select hpp from hpp where id_barang='" + tbKodeBarang.Text + "'", Koneksi.conn);
                tbHpp.Text = cmd.ExecuteScalar().ToString();
                Koneksi.conn.Close();
            }
            catch (Exception x)
            {}
        }
    }
}
