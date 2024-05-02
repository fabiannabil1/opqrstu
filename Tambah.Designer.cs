namespace Latihan_buat_UTS
{
    partial class Tambah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nama_barang = new TextBox();
            Jenis_barang = new TextBox();
            Tambahkan = new Button();
            Nama_Brg = new Label();
            Jenis_brg = new Label();
            Jmlh = new Label();
            Jumlah_barang = new TextBox();
            SuspendLayout();
            // 
            // Nama_barang
            // 
            Nama_barang.Location = new Point(75, 67);
            Nama_barang.Name = "Nama_barang";
            Nama_barang.Size = new Size(317, 23);
            Nama_barang.TabIndex = 0;
            Nama_barang.TextChanged += Nama_barang_TextChanged;
            // 
            // Jenis_barang
            // 
            Jenis_barang.Location = new Point(75, 120);
            Jenis_barang.Multiline = true;
            Jenis_barang.Name = "Jenis_barang";
            Jenis_barang.Size = new Size(317, 23);
            Jenis_barang.TabIndex = 1;
            // 
            // Tambahkan
            // 
            Tambahkan.Location = new Point(75, 296);
            Tambahkan.Name = "Tambahkan";
            Tambahkan.Size = new Size(317, 51);
            Tambahkan.TabIndex = 3;
            Tambahkan.Text = "Tambah";
            Tambahkan.UseVisualStyleBackColor = true;
            Tambahkan.Click += Tambahkan_Click;
            // 
            // Nama_Brg
            // 
            Nama_Brg.AutoSize = true;
            Nama_Brg.Location = new Point(75, 49);
            Nama_Brg.Name = "Nama_Brg";
            Nama_Brg.Size = new Size(79, 15);
            Nama_Brg.TabIndex = 4;
            Nama_Brg.Text = "Nama Barang";
            Nama_Brg.Click += label1_Click;
            // 
            // Jenis_brg
            // 
            Jenis_brg.AutoSize = true;
            Jenis_brg.Location = new Point(75, 102);
            Jenis_brg.Name = "Jenis_brg";
            Jenis_brg.Size = new Size(72, 15);
            Jenis_brg.TabIndex = 5;
            Jenis_brg.Text = "Jenis barang";
            // 
            // Jmlh
            // 
            Jmlh.AutoSize = true;
            Jmlh.Location = new Point(75, 164);
            Jmlh.Name = "Jmlh";
            Jmlh.Size = new Size(45, 15);
            Jmlh.TabIndex = 6;
            Jmlh.Text = "Jumlah";
            Jmlh.Click += Jmlh_Click;
            // 
            // Jumlah_barang
            // 
            Jumlah_barang.Location = new Point(75, 182);
            Jumlah_barang.Name = "Jumlah_barang";
            Jumlah_barang.Size = new Size(317, 23);
            Jumlah_barang.TabIndex = 2;
            Jumlah_barang.TextChanged += Jumlah_barang_TextChanged;
            // 
            // Tambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(Jmlh);
            Controls.Add(Jenis_brg);
            Controls.Add(Nama_Brg);
            Controls.Add(Tambahkan);
            Controls.Add(Jumlah_barang);
            Controls.Add(Jenis_barang);
            Controls.Add(Nama_barang);
            Name = "Tambah";
            Text = "Tambah";
            Load += Tambah_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nama_barang;
        private TextBox Jenis_barang;
        private Button Tambahkan;
        private Label Nama_Brg;
        private Label Jenis_brg;
        private Label Jmlh;
        private TextBox Jumlah_barang;
    }
}