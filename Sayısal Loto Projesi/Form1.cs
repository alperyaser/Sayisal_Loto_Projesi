using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sayısal_Loto_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int s1 = rdn.Next(1, 10);
            int s2 = rdn.Next(1, 10);
            int s3 = rdn.Next(1, 10);
            int s4 = rdn.Next(1, 10);

            label3.Text = s1.ToString();
            label4.Text = s2.ToString();
            label5.Text = s3.ToString();
            label6.Text = s4.ToString();

            int g1 = Convert.ToInt16(textBox1.Text);
            int g2 = Convert.ToInt16(textBox2.Text);
            int g3 = Convert.ToInt16(textBox3.Text);
            int g4 = Convert.ToInt16(textBox4.Text);

            if (g1 == s1)
            {
                textBox1.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.Red;
            }

            if (g2 == s2)
            {
                textBox2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.Red;
            }

            if (g3 == s3)
            {
                textBox3.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.Red;
            }

            if (g4 == s4)
            {
                textBox4.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                textBox4.BackColor = System.Drawing.Color.Red;
            }

            if (g1 == s1 && g2 == s2 && g3 == s3 && g4 == s4)
            {
                MessageBox.Show("Tebrikler Sayısal Loto'yu Kazandınız... \n Ancak kumar büyük günahtır. Dünya için ahiretinizi yakmayınız.", "Bilgi ve Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label8.Text = " Maalesef bu çekilişi kazanamadınız... ";
            }
        }

    }
}
