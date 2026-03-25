namespace Vize_hazırlık
{
    partial class frmKitapListesi
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
            lstKitaplar = new ListBox();
            dgvKitaplar = new DataGridView();
            lblDetay = new Label();
            btnKaydet = new Button();
            btnYukle = new Button();
            btnFiltrele = new Button();
            btnYenile = new Button();
            cmbFiltre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // lstKitaplar
            // 
            lstKitaplar.FormattingEnabled = true;
            lstKitaplar.ItemHeight = 17;
            lstKitaplar.Location = new Point(-1, -2);
            lstKitaplar.Name = "lstKitaplar";
            lstKitaplar.Size = new Size(145, 446);
            lstKitaplar.TabIndex = 0;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(150, 196);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.Size = new Size(650, 128);
            dgvKitaplar.TabIndex = 1;
            // 
            // lblDetay
            // 
            lblDetay.AutoSize = true;
            lblDetay.Location = new Point(172, 24);
            lblDetay.Name = "lblDetay";
            lblDetay.Size = new Size(119, 17);
            lblDetay.TabIndex = 2;
            lblDetay.Text = "Seçilen kitap detayı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(150, 371);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(153, 56);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "XML'e Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(309, 371);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(153, 56);
            btnYukle.TabIndex = 4;
            btnYukle.Text = "XML'den Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(468, 371);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(153, 56);
            btnFiltrele.TabIndex = 5;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(627, 371);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(153, 56);
            btnYenile.TabIndex = 6;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            // 
            // cmbFiltre
            // 
            cmbFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Items.AddRange(new object[] { "Roman", "Bilim", "Tarih", "Çocuk", "Klasik" });
            cmbFiltre.Location = new Point(538, 330);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(242, 25);
            cmbFiltre.TabIndex = 7;
            // 
            // frmKitapListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbFiltre);
            Controls.Add(btnYenile);
            Controls.Add(btnFiltrele);
            Controls.Add(btnYukle);
            Controls.Add(btnKaydet);
            Controls.Add(lblDetay);
            Controls.Add(dgvKitaplar);
            Controls.Add(lstKitaplar);
            Name = "frmKitapListesi";
            Text = "frmKitapListesi";
            Load += frmKitapListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKitaplar;
        private DataGridView dgvKitaplar;
        private Label lblDetay;
        private Button btnKaydet;
        private Button btnYukle;
        private Button btnFiltrele;
        private Button btnYenile;
        private ComboBox cmbFiltre;
    }
}