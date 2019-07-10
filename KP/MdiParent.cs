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
    public partial class MdiParent : Form
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static DataSet ds;
        public MdiParent()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Login.activeuser=="SUPERVISOR")
            {
                FormBayarPiutang piutang = new FormBayarPiutang();
                piutang.MdiParent = this;
                piutang.StartPosition = FormStartPosition.Manual;
                piutang.Location = new Point(10, 0);
                FormBayarHutang hutang = new FormBayarHutang();
                hutang.MdiParent = this;
                hutang.StartPosition = FormStartPosition.Manual;
                hutang.Location = new Point(piutang.Width + 10, 0);
                hutang.Height = piutang.Height;
                hutang.Show();
                piutang.Show();
            }
            else
            {
                pembayaranHutangToolStripMenuItem.Enabled = false;
                piutangToolStripMenuItem1.Enabled = false;
                koreksiStokToolStripMenuItem.Enabled = false;
                koreksiHPPToolStripMenuItem.Enabled = false;
                accountToolStripMenuItem.Enabled = false;
                laporanToolStripMenuItem.Enabled = false;
                produkToolStripMenuItem.Enabled = false;
                pembelianToolStripMenuItem.Enabled = false;
                kategoriToolStripMenuItem.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang f = new FormBarang();
            f.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan f = new FormPenjualan();
            f.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer();
            f.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier f = new FormSupplier();
            f.Show();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembelian p = new FormPembelian();
            p.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.Show();
        }

        private void listProduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFindBarang f = new FormFindBarang();
            f.Show();
        }

        private void addPromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPromo f = new FormPromo();
            f.Show();
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPoinPenjualan f = new FormPoinPenjualan();
            f.Show();
        }

        private void pembelianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPoinPembelian f = new FormPoinPembelian();
            f.Show();
        }

        private void koreksiStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKoreksiStok f = new FormKoreksiStok();
            f.Show();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKartuStok f = new FormKartuStok();
            f.Show();
        }

        private void transaksiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLaporanTransaksi f = new FormLaporanTransaksi();
            f.Show();
        }

        private void pembayaranHutangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBayarHutang f = new FormBayarHutang();
            f.Show();
        }

        private void piutangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBayarPiutang f = new FormBayarPiutang();
            f.Show();
        }

        private void noDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoDrop f = new FormNoDrop();
            f.Show();
        }

        private void hutangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanHutang f = new FormLaporanHutang();
            f.Show();
        }

        private void koreksiHPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateHpp f = new FormUpdateHpp();
            f.Show();
        }

        private void piutangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanPiutang f = new FormLaporanPiutang();
            f.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.Show();
        }

        private void labaRugiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLabaRugi f = new FormLabaRugi();
            f.Show();
        }
    }
}
