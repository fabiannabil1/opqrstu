namespace Latihan_buat_UTS
{
    partial class DataBarang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataProduk = new DataGridView();
            Tambah = new Button();
            ((System.ComponentModel.ISupportInitialize)DataProduk).BeginInit();
            SuspendLayout();
            // 
            // DataProduk
            // 
            DataProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataProduk.Location = new Point(12, 89);
            DataProduk.Name = "DataProduk";
            DataProduk.Size = new Size(1126, 459);
            DataProduk.TabIndex = 1;
            DataProduk.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Tambah
            // 
            Tambah.BackColor = Color.FromArgb(255, 128, 128);
            Tambah.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tambah.Location = new Point(12, 12);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(1126, 71);
            Tambah.TabIndex = 1;
            Tambah.Text = "Tambah";
            Tambah.UseVisualStyleBackColor = false;
            Tambah.Click += button1_Click;
            // 
            // DataBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 560);
            Controls.Add(Tambah);
            Controls.Add(DataProduk);
            Name = "DataBarang";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataProduk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataProduk;
        private Button Tambah;
    }
}
