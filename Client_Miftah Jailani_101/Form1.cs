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
            Console.WriteLine(hasilTambah);
            double hasilKurang = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Console.WriteLine(hasilKurang);
            double hasilKali = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Console.WriteLine(hasilKali);
            double hasilBagi = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            Console.WriteLine(hasilBagi);
            Console.ReadLine();


        }
    }
}
