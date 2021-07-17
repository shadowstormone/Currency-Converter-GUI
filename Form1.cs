using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1
{
    public partial class Form1 : Form
    {
        public const double curs_rub = 76.3802;
        //public const double curs_cny = 0.1527;
        //public const double curs_uah = 0.0359;
        //public const double curs_gbp = 1.3853;
        //public const double curs_eur = 1.1807;
        //public const double curs_kzt = 0.0023;
        //public const double curs_uzs = 0.00009549;
        //public const double curs_gold = 59.183;
        //public const double curs_sek = 0.1148;
        public double togle_usd = 1;

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int togle_usd = (int)Convert.ToDouble(textBox1.Text);

           // textBox1.KeyPress += new KeyPressEventHandler(keypressed);

        }

        //private void keypressed(Object o, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != '\b')
        //        e.Handled = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedItem = index;

            int t = index;

            textBox2.Text = Convert.ToString(t); // Вывод теекста в textBox2

            switch (index)
            {
                case '0':
                    textBox2.Text = Convert.ToString(togle_usd / curs_rub);
                    break;
            }

                    //    case '1':
                    //        curs_cny* togle_usd;
                    //        break;

                    //    case '2':
                    //        togle_usd* curs_uah;
                    //        break;

                    //    case '3':
                    //        curs_gbp* togle_usd;
                    //        break;

                    //    case '4':
                    //        curs_eur* togle_usd;
                    //        break;

                    //    case '5':
                    //        togle_usd* curs_kzt;
                    //        break;

                    //    case '6':
                    //        curs_uzs* togle_usd;
                    //        break;

                    //    case '7':
                    //        curs_gold* togle_usd;
                    //        break;

                    //    case '8':
                    //        togle_usd* curs_sek;
                    //        break;
                    //}
            }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа конвертирует разные валюты и USD", "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
