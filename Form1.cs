using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group_Box_Uygulamaları_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rbRam4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           decimal tabanFiyat = 500;
          decimal cpuFiyat = 0;
          if (rbCpui7.Checked)                                                        
               cpuFiyat = 300;
          else if (rbCpui5.Checked)
               cpuFiyat = 200;
          else if (rbCpui3.Checked)
               cpuFiyat = 100;
          else if (rbCpuR5.Checked)
               cpuFiyat = 250;
          else if (rbCpuR3.Checked)
               cpuFiyat = 150;
          tabanFiyat += cpuFiyat;
          decimal ramFiyat = 0;
          if (rbRam16.Checked)
          ramFiyat = 125;
          else if (rbRam8.Checked)
          ramFiyat = 75;
          else if (rbRam4.Checked)
          ramFiyat = 45;
          tabanFiyat += ramFiyat;
          MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));
}
        }
    }

