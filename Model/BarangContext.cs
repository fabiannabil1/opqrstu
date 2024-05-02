using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Latihan_buat_UTS.Model
{
    public class BarangContext
    {
        string consStr = "Server=localhost;Port=5432;User Id=postgres;Password=010105;Database=Data_Barang;CommandTimeout=10";
        public List<Barang> Read()
        {
            List<Barang> listBarang =new List<Barang>();
            string query = "SELECT nama_barang,jenis_barang,jumlah from barang";
            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Barang barang = new Barang();
                            barang.nama_barang = (string)reader["nama_barang"];
                            barang.jenis_barang = (string)reader["jenis_barang"];
                            barang.jumlah = (int)reader["jumlah"];
                            listBarang.Add(barang);
                        }
                    }
                }
                return listBarang;
            }
        }

        public bool insert(Barang barang)
        {
            bool isSuccess = false;
            string query = "INSERT INTO Barang (nama_barang, jenis_barang, jumlah) VALUES (@nama_barang, @jenis_barang, @jumlah)";

            using (NpgsqlConnection conn = new NpgsqlConnection(consStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_barang", barang.nama_barang);
                    cmd.Parameters.AddWithValue("@jenis_barang", barang.jenis_barang);
                    cmd.Parameters.AddWithValue("@jumlah", barang.jumlah); // Pastikan barang.jumlah adalah tipe data numerik

                    int eksekusi = cmd.ExecuteNonQuery();
                    isSuccess = eksekusi > 0;
                }
            }
            return isSuccess;
        }
    }
}
