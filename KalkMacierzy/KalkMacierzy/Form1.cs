using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkMacierzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDodawanie_Click(object sender, EventArgs e)
        {
            Dodawanie dod = new Dodawanie();
            dod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odejmowanie odj = new Odejmowanie();
            odj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mnozenie mn = new Mnozenie();
            mn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wyznacznik wn = new Wyznacznik();
            wn.Show();
        }
    }
}
