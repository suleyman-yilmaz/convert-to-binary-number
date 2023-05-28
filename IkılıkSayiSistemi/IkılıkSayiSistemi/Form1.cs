using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkılıkSayiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                List<int> binaryDigits = new List<int>();

                while (number > 0)
                {
                    int remainder = number % 2;
                    binaryDigits.Add(remainder);
                    number = number / 2;
                }

                binaryDigits.Reverse(); // Digits'i ters çevirin

                string binaryString = string.Join("", binaryDigits); // Digits'i birleştirin

                MessageBox.Show("Girilen Sayının İkilik Sayı Sistemindeki Karşılığı : " + binaryString);
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz Sayı Geçersizdir !!!");
            }
        }
    }
}
