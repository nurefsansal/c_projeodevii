using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ülker");
            comboBox1.Items.Add("Milka");
            comboBox1.Items.Add("Torku");
            comboBox1.Items.Add("Tadella");
            comboBox1.Items.Add("Kinder");
            comboBox1.Items.Add("Eti");


            comboBox2.Items.Add("Ülker");
            comboBox2.Items.Add("Milka");
            comboBox2.Items.Add("Torku");
            comboBox2.Items.Add("Tadella");
            comboBox2.Items.Add("Kinder");
            comboBox2.Items.Add("Eti");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Ülker")
            {
                label3.Text =" 13,50 TL ";
            }

            else if (comboBox1.Text=="Milka")
            {
                label3.Text =" 28,00 TL ";

            }
            else if (comboBox1.Text=="Torku")
            {
                label3.Text =" 19,75 TL ";

            }
            else if (comboBox1.Text=="Tadella")
            {
                label3.Text =" 10,45 TL ";

            }
            else if (comboBox1.Text=="Kinder")
            {
                label3.Text =" 19,25 TL ";

            }
            else if (comboBox1.Text=="Eti")
            {
                label3.Text =" 14,95 TL ";

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="Ülker")
            {
                label4.Text =" 13,50 TL ";
            }

            else if (comboBox2.Text=="Milka")
            {
                label4.Text =" 28,00 TL ";

            }
            else if (comboBox2.Text=="Torku")
            {
                label4.Text =" 19,75 TL ";

            }
            else if (comboBox2.Text=="Tadella")
            {
                label4.Text =" 10,45 TL ";

            }
            else if (comboBox2.Text=="Kinder")
            {
                label4.Text =" 19,25 TL ";

            }
            else if (comboBox2.Text=="Eti")
            {
                label4.Text =" 14,95 TL ";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayiLabel3 = Convert.ToDouble(label3.Text.Replace(" TL", "").Trim());
            double sayiLabel4 = Convert.ToDouble(label4.Text.Replace(" TL", "").Trim());


            double fark = sayiLabel3 - sayiLabel4;
            label5.Text = $"Fark: {Math.Abs(fark):C}";
        }
    }
}
