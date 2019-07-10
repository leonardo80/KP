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
    public partial class FormUser : Form
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static DataSet ds;
        public static string sql;
        public static string temp = "";

        public FormUser()
        {
            InitializeComponent();
        }

        public void load()
        {
            Koneksi.openConn();
            da = new MySqlDataAdapter("select nama_user as Username, password_user as Pass, pangkat as Pangkat from user", Koneksi.conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUser.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPass.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnUpdate.Enabled = true;button1.Enabled = true;
            temp = tbUser.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Koneksi.openConn();
            cmd = new MySqlCommand("insert into user values('"+tbUser.Text+"','"+tbPass.Text+"','"+tbPangkat.Text+"')", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
            button1.Enabled = false;btnUpdate.Enabled = false;
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;button1.Enabled = false;
            Koneksi.openConn();
            cmd = new MySqlCommand("update user set password_user ='"+tbPass.Text+"', nama_user='"+tbUser.Text+"' where nama_user='"+temp+"'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;btnUpdate.Enabled = false;
            Koneksi.openConn();
            cmd = new MySqlCommand("delete from user where nama_user='" + temp + "'", Koneksi.conn);
            cmd.ExecuteNonQuery();
            Koneksi.conn.Close();
            load();
        }
    }
}
