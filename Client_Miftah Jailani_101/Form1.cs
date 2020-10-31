using ServiceMtk_P1_101;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Miftah_Jailani_101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new
            ChannelFactory<IMatematika>(bind, "http://localhost:1910");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Hasil Penjumlahan : " + hasilTambah; //add label1.Text + var hasilTambah
            double hasilKurang = obj.Kurang(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label4.Text = "Hasil Pengurangan : " + hasilKurang; //add label1.Text + var hasilTambah
            double hasilKali = obj.Kali(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label5.Text = "Hasil Perkalian : " + hasilKali; //add label1.Text + var hasilTambah
            double hasilBagi = obj.Bagi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label6.Text = "Hasil Pembagian : " + hasilBagi; //add label1.Text + var hasilTambah
            Console.ReadLine();
        }
    }
}
