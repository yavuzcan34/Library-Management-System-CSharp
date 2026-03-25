namespace Vize_hazırlık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapListesi formGiris = new frmKitapListesi();
            formGiris.MdiParent = this; // Formu ana formun içine hapseder
            formGiris.Show();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapGiris formGiris = new frmKitapGiris();
            formGiris.MdiParent = this; // Formu ana formun içine hapseder
            formGiris.Show();
        }
    }
}
