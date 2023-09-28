namespace SifreKontrolUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KontrolEtButton_Click(object sender, EventArgs e)
        {
            string girilenSifre = txtSifreAlan.Text;

            // Şifre kontrolü burada gerçekleştirilebilir.
            string dogruSifre = "gizli_sifre";

            if (girilenSifre == dogruSifre)
            {
                MessageBox.Show("Şifre doğru!", "Başarılı");
            }
            else
            {
                MessageBox.Show("Şifre yanlış!", "Hata");
            }
        }

    }
}
