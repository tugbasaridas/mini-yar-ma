using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yarisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "kategori seç";
            pictureBox1.Image = Image.FromFile(@"C:\Users\Tuğba\Desktop\png\edebiyat.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.DoubleClick += new EventHandler(pictureBox1_DoubleClick);


            pictureBox2.Image = Image.FromFile(@"C:\Users\Tuğba\Desktop\png\math.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.DoubleClick += new EventHandler(pictureBox2_DoubleClick);


            pictureBox3.Image = Image.FromFile(@"C:\Users\Tuğba\Desktop\png\cografya.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.DoubleClick += new EventHandler(pictureBox3_DoubleClick);

        }
        List<Question> edebiyatSorulari = new List<Question>
{
    new Question
    {
        Text = "Namık Kemal'in en ünlü eseri nedir?",
        Options = new string[] { "İntibah", "Zehra", "Vatan Yahut Silistre", "Sergüzeşt" },
        CorrectAnswer = "C"
    },
    new Question
    {
        Text = "Divan edebiyatı hangi alfabe ile yazılmıştır?",
        Options = new string[] { "Latin", "Arap", "Kirill", "Göktürk" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "Servet-i Fünun topluluğunun öncüsü kimdir?",
        Options = new string[] { "Tevfik Fikret", "Namık Kemal", "Ahmet Haşim", "Ziya Paşa" },
        CorrectAnswer = "A"
    },
     new Question
    {
        Text = "Halide Edib Adıvar'ın en bilinen romanı hangisidir?",
        Options = new string[] { "Sinekli Bakkal", "Ateşten Gömlek", "Vurun Kahpeye", "Handan" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "Türk edebiyatında ilk roman hangisidir?",
        Options = new string[] { "Taaşşuk-ı Talat ve Fitnat", "Araba Sevdası", "İntibah", "Felatun Bey ile Rakım Efendi" },
        CorrectAnswer = "A"
    },
    new Question
    {
        Text = "Ahmet Hamdi Tanpınar'ın en bilinen eseri hangisidir?",
        Options = new string[] { "Saatleri Ayarlama Enstitüsü", "Huzur", "Beş Şehir", "Mahur Beste" },
        CorrectAnswer = "A"
    },
    new Question
    {
        Text = "Orhan Pamuk, Nobel Edebiyat Ödülü'nü hangi yıl kazanmıştır?",
        Options = new string[] { "2004", "2005", "2006", "2007" },
        CorrectAnswer = "C"
    },
    new Question
    {
        Text = "Garip Akımı'nın öncülerinden biri kimdir?",
        Options = new string[] { "Nazım Hikmet", "Orhan Veli Kanık", "Cemal Süreya", "Turgut Uyar" },
        CorrectAnswer = "B"
    }
};
        List<Question> matematikSorulari = new List<Question>
{
    new Question
    {
        Text = "3 + 4 x 2 işleminin sonucu nedir?",
        Options = new string[] { "14", "11", "10", "7" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "Bir üçgende iç açılar toplamı kaç derecedir?",
        Options = new string[] { "90", "180", "270", "360" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "π sayısının yaklaşık değeri nedir?",
        Options = new string[] { "3.14", "2.71", "1.41", "1.61" },
        CorrectAnswer = "A"
    },
     new Question
    {
        Text = "Bir dik üçgende, dik kenarlar 3 cm ve 4 cm ise hipotenüs kaç cm'dir?",
        Options = new string[] { "5", "6", "7", "8" },
        CorrectAnswer = "A"
    },
    new Question
    {
        Text = "Bir karenin alanı 49 cm² ise bir kenarının uzunluğu kaç cm'dir?",
        Options = new string[] { "5", "6", "7", "8" },
        CorrectAnswer = "C"
    },
    new Question
    {
        Text = "12 sayısının asal çarpanları toplamı kaçtır?",
        Options = new string[] { "5", "7", "9", "12" },
        CorrectAnswer = "B"  // 2 ve 3 -> 2 + 3 = 5
    },
    new Question
    {
        Text = "Bir saatte 60 dakika vardır. 3 saat kaç dakikadır?",
        Options = new string[] { "90", "120", "150", "180" },
        CorrectAnswer = "D"
    },
    new Question
    {
        Text = "Bir otobüste 40 yolcu vardı. 15’i indi, 10 kişi bindi. Şu an otobüste kaç kişi var?",
        Options = new string[] { "35", "30", "25", "40" },
        CorrectAnswer = "A"
    }
};

        List<Question> cografyaSorulari = new List<Question>
{
    new Question
    {
        Text = "Türkiye'nin en büyük gölü hangisidir?",
        Options = new string[] { "Van Gölü", "Tuz Gölü", "Beyşehir Gölü", "Sapanca Gölü" },
        CorrectAnswer = "A"
    },
    new Question
    {
        Text = "İstanbul Boğazı hangi iki denizi bağlar?",
        Options = new string[] { "Ege - Marmara", "Karadeniz - Ege", "Karadeniz - Marmara", "Marmara - Akdeniz" },
        CorrectAnswer = "C"
    },
    new Question
    {
        Text = "Ekvator çizgisi nedir?",
        Options = new string[] { "Başlangıç paraleli", "Meridyen", "Tropik çizgi", "Yükseklik eğrisi" },
        CorrectAnswer = "A"
    },
     new Question
    {
        Text = "Dünyanın en uzun nehri hangisidir?",
        Options = new string[] { "Amazon", "Nil", "Mississippi", "Yangtze" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "Hangi ülke yüzölçümü bakımından dünyanın en büyüğüdür?",
        Options = new string[] { "Çin", "Amerika", "Kanada", "Rusya" },
        CorrectAnswer = "D"
    },
    new Question
    {
        Text = "Türkiye'nin en yüksek dağı hangisidir?",
        Options = new string[] { "Erciyes", "Ağrı Dağı", "Kaçkar Dağı", "Süphan Dağı" },
        CorrectAnswer = "B"
    },
    new Question
    {
        Text = "Karadeniz Bölgesi'nin en çok yağış alan ili hangisidir?",
        Options = new string[] { "Rize", "Trabzon", "Artvin", "Ordu" },
        CorrectAnswer = "A"
    },
    new Question
    {
        Text = "Akdeniz ikliminde en çok yetiştirilen tarım ürünü hangisidir?",
        Options = new string[] { "Buğday", "Pamuk", "Zeytin", "Şeker pancarı" },
        CorrectAnswer = "C"
    }
};

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Testform testForm = new Testform(edebiyatSorulari);
            testForm.Show();


        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Testform testForm = new Testform(matematikSorulari);
          
            testForm.Show();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Testform testForm = new Testform(cografyaSorulari);
            testForm.Show();

        }
    }

    }

