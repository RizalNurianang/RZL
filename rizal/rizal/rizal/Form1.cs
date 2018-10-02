using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using terbilang;



namespace rizal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cek_Click(object sender, EventArgs e)
        {
            int cek = int.Parse(angka.Text);
            Terbilang Terbilang = new Terbilang ();
            list.Items.Clear();
            list.Items.Add(Terbilang.TerbilangIndonesia(cek));


        }
    }
}
