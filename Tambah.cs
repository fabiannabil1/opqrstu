using Latihan_buat_UTS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_buat_UTS;
using System.Runtime.CompilerServices;

namespace Latihan_buat_UTS
{
    public partial class Tambah : Form
    {
        private BarangContext barangContext;
       

        public Tambah()
        {
            this.IsMdiContainer = false;
            InitializeComponent();
            
        }

        public void loadData()
        {
            BarangContext barangContext = new BarangContext();
            List<Barang> listbarang = barangContext.Read();
            
        }

        public Barang GetBarang()
        {
            
            Barang barang = new Barang();
            barang.nama_barang = Nama_barang.Text;
            barang.jenis_barang = Jenis_barang.Text;
            barang.jumlah = Convert.ToInt32(Jumlah_barang.Text);
            return barang;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jmlh_Click(object sender, EventArgs e)
        {

        }

        private void Nama_barang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tambahkan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Tambah_Load(object sender, EventArgs e)
        {

        }

        private void Jumlah_barang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
