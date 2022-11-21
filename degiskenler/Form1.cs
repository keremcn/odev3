namespace degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void kacsaat_Click(object sender, EventArgs e)
        {
            int girdi = Convert.ToInt32(textBox1.Text);            

            int sonuc = (int)((double)girdi / 60);
            int kalan = girdi % 60;

            kacsaat.Text = sonuc + " saat:" + kalan+ " dakika";
        }

        private void sayiyazi_Click(object sender, EventArgs e)
        {
            string g = textBox2.Text;
            switch (g)
            {
                case "0":
                    sayiyazi.Text = "Sýfýr";
                    break;
                case "1":
                    sayiyazi.Text = "Bir";
                    break;
                case "2":
                    sayiyazi.Text = "Ýki";
                    break;
                case "3":
                    sayiyazi.Text = "Üç";
                    break;
                case "4":
                    sayiyazi.Text = "Dört";
                    break;
                case "5":
                    sayiyazi.Text = "Beþ";
                    break;
                case "6":
                    sayiyazi.Text = "Altý";
                    break;
                case "7":
                    sayiyazi.Text = "Yedi";
                    break;
                case "8":
                    sayiyazi.Text = "Sekiz";
                    break;
                case "9":
                    sayiyazi.Text = "Dokuz";
                    break;
                default:
                    sayiyazi.Text = "0 - 9 arasýnda girin";
                    break;
            }

            
        }

        private void kacbasamak_Click(object sender, EventArgs e)
        {
            int girdi = Convert.ToInt32(textBox3.Text);

            int basamak = 0;
            while (girdi > 0)
            {
                basamak++;
                girdi = girdi / 10;
            }
            

            kacbasamak.Text = basamak + " basamaklý";
        }

        private void karetoplam_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i = 0; i<100; i++)
            {
                if (i % 7 == 0) {
                    toplam = toplam + i*i;
                }
            }
            karetoplam.Text = "toplam "+toplam;

        }

        private void asalmi_Click(object sender, EventArgs e)
        {
            string sonuc = "Asal";
            
            int girdi = Convert.ToInt32(textBox4.Text);
            for(int i=2; i<girdi/2; i++)
            {
                if (girdi % i == 0) { sonuc = "Asal deðil";  break; }
                
            }
            asalmi.Text = sonuc;
        }

        private void haftagun_Click(object sender, EventArgs e)
        {
            string g = textBox5.Text;
            switch (g)
            {
                case "1":
                    haftagun.Text = "Pazartesi";
                    break;
                case "2":
                    haftagun.Text = "Salý";
                    break;
                case "3":
                    haftagun.Text = "Çarþamba";
                    break;
                case "4":
                    haftagun.Text = "Perþembe";
                    break;
                case "5":
                    haftagun.Text = "Cuma";
                    break;
                case "6":
                    haftagun.Text = "Cumartesi";
                    break;
                case "7":
                    haftagun.Text = "Pazar";
                    break;
                default:
                    haftagun.Text = "1-7 arasýnda olmalý";
                    break;
            }
        }

        private void yildiz_Click(object sender, EventArgs e)
        {
            int girdi = Convert.ToInt32(textBox6.Text);
            string sonuc = "";
            for (int i = 0; i < girdi; i++)
            { sonuc = sonuc + "*";}
            yildiz.Text = sonuc;
        }

        private void seri_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            int y = 0;
            int x = 0;
            while (y < 100)
            {
                y = 3 * x + 1;
                sonuc = sonuc + "," + y;
                x++;
            }
            seri.Text = sonuc;
        }

        private void enkucuk_Click(object sender, EventArgs e)
        {
            int girdi1 = Convert.ToInt32(textBox7.Text);
            int girdi2 = Convert.ToInt32(textBox8.Text);
            int girdi3 = Convert.ToInt32(textBox9.Text);

            int enk = girdi1;
            if(girdi2<enk) enk = girdi2;
            if(girdi3<enk) enk = girdi3;

            enkucuk.Text = "En küçük deðer: " + enk;

        }

        private void denklem_Click(object sender, EventArgs e)
        {
            
            string sonuc = "";
            int fx_1 = -1; // f(-1)
            int fx = 1; // f(0)
            int fx1 = 0;

            for(int x=0; x<=10; x++)
            {
                //x= 0 // f(1) = f(-1) + f(0)
                //x=1 // f2 = f0 +f1
                //x2 // f3 = f1+f2
                fx1 = fx_1 + fx;
                sonuc +=fx1+ " ,";
                fx_1 = fx;
                fx = fx1;

 
            }
            
            denklem.Text = sonuc;
        }
    }
}