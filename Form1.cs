using Latihan_buat_UTS.Model;
using System;

namespace Latihan_buat_UTS
{
    public partial class DataBarang : Form
    {
        BarangContext barangContext;
        public DataBarang()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            barangContext = new BarangContext();
            loadData();
        }

        public void loadData()
        {
            BarangContext barangContext = new BarangContext();
            List<Barang> listbarang = barangContext.Read();
            DataProduk.DataSource = listbarang;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using(Tambah tambah = new Tambah())
            {
                if (tambah.ShowDialog() == DialogResult.OK)
                {
                    Barang barang = tambah.GetBarang();
                    barangContext.insert(barang);
                    loadData();
                    tambah.Close();
                }
            }
            
            //Barang barangbaru = tambah.GetBarang();
            //if (barangContext.insert(barangbaru))
            //{
            //    MessageBox.Show("Barang berhasil ditambah");
            //    loadData();
            //}
            //else
            //{
            //    MessageBox.Show("Barang gagal ditambah");
            //}

            //loadData();
            //loadData();

            //Barang barangbaru = tambah.GetBarang();
            //if (barangContext.insert(barangbaru))
            //{
            //    MessageBox.Show("Barang berhasil ditambah");
            //    loadData();
            //}
            //else
            //{
            //    MessageBox.Show("Barang gagal ditambah");
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
