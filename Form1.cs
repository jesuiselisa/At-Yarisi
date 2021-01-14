using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void btnReset_Click_1(object sender, EventArgs e)
        { 
            pic1.Left = label10.Left;
            pic2.Left = label10.Left;
            pic3.Left = label10.Left;
            pic4.Left = label10.Left;
            pic5.Left = label10.Left;
            pic6.Left = label10.Left;
            label1.Text = "Henüz Yarış Başlamadı";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int birAtGen = pic1.Width;
            int ikiAtGen = pic2.Width;
            int üçAtGen = pic3.Width;
            int dörtAtGen = pic4.Width;
            int beşAtGen = pic5.Width;
            int altıAtGen = pic6.Width;

            pic1.Left = pic1.Left + rnd.Next(1, 15);
            pic2.Left = pic2.Left + rnd.Next(1, 15);
            pic3.Left = pic3.Left + rnd.Next(1, 15);
            pic4.Left = pic4.Left + rnd.Next(1, 15);
            pic5.Left = pic5.Left + rnd.Next(1, 15);
            pic6.Left = pic6.Left + rnd.Next(1, 15);

            int bitiş = label2.Left;


            if (pic2.Left < pic1.Left && pic3.Left < pic1.Left && pic4.Left < pic1.Left && pic5.Left < pic1.Left && pic6.Left < pic1.Left)
            {
                label1.Text = "1. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }
            else if (pic1.Left < pic2.Left && pic3.Left < pic2.Left && pic4.Left < pic2.Left && pic5.Left < pic2.Left && pic6.Left < pic2.Left)
            {
                label1.Text = "2. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }
            else if (pic2.Left < pic3.Left && pic1.Left < pic3.Left && pic4.Left < pic3.Left && pic5.Left < pic3.Left && pic6.Left < pic3.Left)
            {
                label1.Text = "3. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }
            else if (pic2.Left < pic4.Left && pic1.Left < pic4.Left && pic3.Left < pic4.Left && pic5.Left < pic4.Left && pic6.Left < pic4.Left)
            {
                label1.Text = "4. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }
            else if (pic2.Left < pic5.Left && pic1.Left < pic5.Left && pic3.Left < pic5.Left && pic4.Left < pic5.Left && pic6.Left < pic5.Left)
            {
                label1.Text = "5. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }
            else
            {
                label1.Text = "6. At Yarışı Önde Götürüyor Değerli Seyirciler";
            }


            if (pic1.Left + birAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("Birinci At Yarışı Kazandı");
            }
            else if (pic2.Left + ikiAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("İkinci At Yarışı Kazandı");
            }
            else if (pic3.Left + üçAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("Üçüncü At Yarışı Kazandı");
            }
            else if (pic4.Left + dörtAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("Dördüncü At Yarışı Kazandı");
            }
            else if (pic5.Left + beşAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("Beşinci At Yarışı Kazandı");
            }
            else if (pic6.Left + altıAtGen >= bitiş)
            {
                timer1.Stop();
                MessageBox.Show("Altıncı At Yarışı Kazandı");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

       

    }
}
