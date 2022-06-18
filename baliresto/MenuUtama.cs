using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baliresto
{
    public partial class MenuUtama : Form
    {
     
        int hasil1 = 0;
        int diskon = 0;
        int beforediskon = 0;
        int afterdiskon = 0;
        int uangmasuk = 0;
        int uangperlu = 0;
        int uangkembali = 0;
       
       
        public MenuUtama()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Ayam Goreng")
            {
                textBox3.Text = "13000";
            }
            else if (comboBox2.SelectedItem.ToString() == "Nasi Goreng")
            {
                textBox3.Text = "12000";
            }
            else if (comboBox2.SelectedItem.ToString() == "Mie Ayam")
            {
                textBox3.Text = "10000";
            }
            else if (comboBox2.SelectedItem.ToString() == "Es Teh")
            {
                textBox3.Text = "5000";
            }
            else if (comboBox2.SelectedItem.ToString() == "Es Campur")
            {
                textBox3.Text = "10000";
            }
            else if (comboBox2.SelectedItem.ToString() == "Cappucino")
            {
                textBox3.Text = "8000";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Makanan")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ayam Goreng");
                comboBox2.Items.Add("Nasi Goreng");
                comboBox2.Items.Add("Mie Ayam");
            }
            else if (comboBox1.SelectedItem.ToString() == "Minuman")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Es Teh");
                comboBox2.Items.Add("Es Campur");
                comboBox2.Items.Add("Cappucino");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1 = (int)Convert.ToUInt64(textBox3.Text);
            int angka2 = (int)Convert.ToUInt64(textBox4.Text);

            int hasil1 = angka1 * angka2;
          int sub1 = (int)Convert.ToUInt64(textBox5.Text);
            int subtotal = sub1 + hasil1;
            textBox5.Text = subtotal.ToString();

        
                textBox8.Text = textBox5.Text;
      

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = "0";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int diskon = (int)Convert.ToUInt64(textBox6.Text);
            int beforediskon = (int)Convert.ToUInt64(textBox5.Text);
            int afterdiskon = beforediskon - (beforediskon * diskon / 100);
            textBox8.Text = afterdiskon.ToString();
         
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int uangmasuk = (int)Convert.ToUInt64(textBox9.Text);
            int uangperlu = (int)Convert.ToUInt64(textBox8.Text);
            int uangkembali = uangmasuk - uangperlu;
            textBox10.Text = uangkembali.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
