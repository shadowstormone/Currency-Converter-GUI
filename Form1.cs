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
        public const double curs_cny = 0.1527;
        public const double curs_uah = 0.0359;
        public const double curs_gbp = 1.3853;
        public const double curs_eur = 1.1807;
        public const double curs_kzt = 0.0023;
        public const double curs_uzs = 0.00009549;
        public const double curs_gold = 59.183;
        public const double curs_sek = 0.1148;

        public static class Globals
        {
            public static double togle_usd = 1;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.FindString(comboBox1.Text);
            comboBox1.SelectedItem = index;

            //textBox2.Text = Convert.ToString(t); // Вывод теекста в textBox2

            switch (index)
            {
                case 0:
                    double result0 = Globals.togle_usd / curs_rub;

                    textBox2.Text = Convert.ToString(result0);
            break;

                case 1:
                    textBox2.Text = Convert.ToString(curs_cny * Globals.togle_usd);
            break;

                case 2:
                    textBox2.Text = Convert.ToString(Globals.togle_usd * curs_uah);
            break;

                case 3:
                    textBox2.Text = Convert.ToString(curs_gbp * Globals.togle_usd);
            break;

                case 4:
                    textBox2.Text = Convert.ToString(curs_eur * Globals.togle_usd);
            break;

                case 5:
                    textBox2.Text = Convert.ToString(Globals.togle_usd * curs_kzt);
            break;

                case 6:
                    textBox2.Text = Convert.ToString(curs_uzs * Globals.togle_usd);
            break;

                case 7:
                    textBox2.Text = Convert.ToString(curs_gold * Globals.togle_usd);
            break;

                case 8:
                    textBox2.Text = Convert.ToString(Globals.togle_usd * curs_sek);
            break;
            }
     
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

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Globals.togle_usd = Convert.ToDouble(numericUpDown1.Value);
        }
    }
}
