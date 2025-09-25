using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace yarisma
{
    public partial class Testform : Form
    {
        private List<Question> sorular;
        private int currentQuestionIndex = 0;
        private int score = 0;


        public Testform(List<Question> gelenSorular)
        {
            InitializeComponent();
            this.sorular = gelenSorular;

            // Rastgele bir soru seçelim
            Random rnd = new Random();
            this.sorular = gelenSorular.OrderBy(x => rnd.Next()).Take(4).ToList();

        }
     

        private void Testform_Load(object sender, EventArgs e)
        {
            SoruGoster();

        }
        private void SoruGoster()
        {
            if (currentQuestionIndex >= sorular.Count)
            {
                int toplamPuan = score * 25;
                MessageBox.Show("Test tamamlandı.\nPuanınız: " + toplamPuan + " / 100", "Sonuç");
                this.Close(); // Testform'u kapat (Form1 açık kalacak)
                return;
            }

            var soru = sorular[currentQuestionIndex];

            label1.Text = soru.Text;

            radioButton1.Text = "A) " + soru.Options[0];
            radioButton2.Text = "B) " + soru.Options[1];
            radioButton3.Text = "C) " + soru.Options[2];
            radioButton4.Text = "D) " + soru.Options[3];

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string secilenSecenek = "";

            if (radioButton1.Checked) secilenSecenek = "A";
            else if (radioButton2.Checked) secilenSecenek = "B";
            else if (radioButton3.Checked) secilenSecenek = "C";
            else if (radioButton4.Checked) secilenSecenek = "D";

            if (string.IsNullOrEmpty(secilenSecenek))
            {
                MessageBox.Show("Lütfen bir seçenek işaretleyin.");
                return;
            }

            if (secilenSecenek == sorular[currentQuestionIndex].CorrectAnswer)
            {
                score++;
                MessageBox.Show("Tebrikler, doğru cevap!");
            }
            else
            {
                MessageBox.Show("Yanlış cevap.");
            }
            currentQuestionIndex++;
            SoruGoster();
        }
    }
}
