namespace KULLANİCİGİRİSİ
{
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {

        }

        string adminKullaniciAdi = "Berkan", adminSifre = "12345"; //Giriş Ekranı için admin kullanıcı adı ve şifresini oluşturduk.

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, kullaniciSifre; //Yeni string ifadeleri oluşturuyoruz.

            kullaniciAdi=txtKullaniciAdi.Text;  //textbox a girilen değeri alıp kullaniciAdi isimli stringe atıyoruz.

            kullaniciSifre=txtSifre.Text;   //textbox a girilen değeri alıp kullaniciSifre isimli stringe atıyoruz.


            if (kullaniciAdi != "" && kullaniciSifre != "") //kullaniciAdi ve kullaniciSifre boş mu?
            {
                if (kullaniciAdi == adminKullaniciAdi && kullaniciSifre == adminSifre) //Ekrana girilen değerler doğru mu kontrol ediyoruz
                {

                    Form1 yeniForm = new Form1(); //yeniforrm nesnesini oluşturduk.

                    this.Hide(); //yeni form açıldığında giriş ekranını görmemek için yazdık.

                    yeniForm.ShowDialog(); //Diğer Form ekranını açıyoruz.

                }
                else
                {

                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else
            {

                MessageBox.Show("Boş Alan Bırakılamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void lblHata_Click(object sender, EventArgs e)
        {

        }
    }
}
