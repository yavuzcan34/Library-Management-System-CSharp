namespace Vize_hazırlık
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            kitaplarToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            kitapGirişToolStripMenuItem = new ToolStripMenuItem();
            kToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, kitaplarToolStripMenuItem, görünümToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(56, 21);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kitaplarToolStripMenuItem
            // 
            kitaplarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapGirişToolStripMenuItem, kitapToolStripMenuItem, kToolStripMenuItem });
            kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            kitaplarToolStripMenuItem.Size = new Size(65, 21);
            kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(74, 21);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(60, 21);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(180, 22);
            kitapToolStripMenuItem.Text = "Kitap Listesi";
            kitapToolStripMenuItem.Click += kitapToolStripMenuItem_Click;
            // 
            // kitapGirişToolStripMenuItem
            // 
            kitapGirişToolStripMenuItem.Name = "kitapGirişToolStripMenuItem";
            kitapGirişToolStripMenuItem.Size = new Size(180, 22);
            kitapGirişToolStripMenuItem.Text = "Kitap Giriş";
            kitapGirişToolStripMenuItem.Click += kitapGirişToolStripMenuItem_Click;
            // 
            // kToolStripMenuItem
            // 
            kToolStripMenuItem.Name = "kToolStripMenuItem";
            kToolStripMenuItem.Size = new Size(180, 22);
            kToolStripMenuItem.Text = "k";
            kToolStripMenuItem.Click += kToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 520);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem kitaplarToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private ToolStripMenuItem kitapGirişToolStripMenuItem;
        private ToolStripMenuItem kToolStripMenuItem;
    }
}
