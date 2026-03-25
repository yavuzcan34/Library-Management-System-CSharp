namespace Vize_hazırlık
{
    partial class frmKitapGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapGiris));
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtISBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtYayinevi = new TextBox();
            txtYil = new TextBox();
            cmbKategori = new ComboBox();
            cmbDurum = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btnEkle = new Button();
            btnTemizle = new Button();
            SuspendLayout();
            // 
            // txtKitapAdi
            // 
            resources.ApplyResources(txtKitapAdi, "txtKitapAdi");
            txtKitapAdi.Name = "txtKitapAdi";
            // 
            // txtYazar
            // 
            resources.ApplyResources(txtYazar, "txtYazar");
            txtYazar.Name = "txtYazar";
            // 
            // txtISBN
            // 
            resources.ApplyResources(txtISBN, "txtISBN");
            txtISBN.Name = "txtISBN";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtYayinevi
            // 
            resources.ApplyResources(txtYayinevi, "txtYayinevi");
            txtYayinevi.Name = "txtYayinevi";
            // 
            // txtYil
            // 
            resources.ApplyResources(txtYil, "txtYil");
            txtYil.Name = "txtYil";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { resources.GetString("cmbKategori.Items"), resources.GetString("cmbKategori.Items1"), resources.GetString("cmbKategori.Items2"), resources.GetString("cmbKategori.Items3"), resources.GetString("cmbKategori.Items4") });
            resources.ApplyResources(cmbKategori, "cmbKategori");
            cmbKategori.Name = "cmbKategori";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { resources.GetString("cmbDurum.Items"), resources.GetString("cmbDurum.Items1"), resources.GetString("cmbDurum.Items2") });
            resources.ApplyResources(cmbDurum, "cmbDurum");
            cmbDurum.Name = "cmbDurum";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // btnEkle
            // 
            resources.ApplyResources(btnEkle, "btnEkle");
            btnEkle.Name = "btnEkle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnTemizle
            // 
            resources.ApplyResources(btnTemizle, "btnTemizle");
            btnTemizle.Name = "btnTemizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // frmKitapGiris
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTemizle);
            Controls.Add(btnEkle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbDurum);
            Controls.Add(cmbKategori);
            Controls.Add(txtYil);
            Controls.Add(txtYayinevi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtISBN);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Name = "frmKitapGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtISBN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtYayinevi;
        private TextBox txtYil;
        private ComboBox cmbKategori;
        private ComboBox cmbDurum;
        private Label label6;
        private Label label7;
        private Button btnEkle;
        private Button btnTemizle;
    }
}