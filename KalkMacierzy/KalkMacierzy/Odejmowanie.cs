using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using KalkMacierzyLib;


namespace KalkMacierzy
{
    public partial class Odejmowanie : Form
    {
        TextBox[] arr = new TextBox[100];
        TextBox[] arr2 = new TextBox[100];
        TextBox[] arr3 = new TextBox[100];
        int[] arr4 = new int[100];
        int[] arr5 = new int[100];
        int[] arr6 = new int[100];

        [DllImport("KalkMacierzyLib.dll")]
        public static extern void OdejmowanieMacierzy(int[] pierwsza, int[] druga, int[] trzecia);

        public Odejmowanie()
        {
            InitializeComponent();
        }

        private void BtnOdjZatwierdz_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textODJKol.Text);
                double b = Convert.ToDouble(textODJW.Text);
                int x = 10, x2 = 200;
                int y = 100, y2 = 100;
                int o = 0, p = 0;
                for (int j = 0; j < b; j++) // TWORZENIE PIERWSZEJ PUSTEJ MACIERZY
                {

                    for (int i = 0; i < a; i++)
                    {

                        var tbox = new TextBox();
                        this.Controls.Add(tbox);
                        arr[o] = tbox;
                        tbox.Width = 20;
                        tbox.Location = new Point(x, y);
                        x += 20;
                        o += 1;
                    }

                    y += 20;
                    x = 10;
                }
                for (int j = 0; j < b; j++) // TWORZENIE DRUGIEJ PUSTEJ MACIERZY
                {

                    for (int i = 0; i < a; i++)
                    {
                        var tbox = new TextBox();
                        this.Controls.Add(tbox);
                        arr2[p] = tbox;
                        tbox.Width = 20;
                        tbox.Location = new Point(x2, y2);
                        x2 += 20;
                        p += 1;
                    }
                    y2 += 20;
                    x2 = 200;
                }
                btnOdejmijDod.Enabled = true;
            }catch
            {
               MessageBox.Show("Zle podane wymiary", "Wyskoczyl blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdejmijDod_Click(object sender, EventArgs e)
        {
            try
            {
                string test = Convert.ToString(arr[1].Text);
                int o = 0;
                double a = Convert.ToDouble(textODJKol.Text);
                double b = Convert.ToDouble(textODJW.Text);
                int x = 100, y = 200;
                int dl4, dl5;
                dl4 = arr.Length;
                dl5 = arr2.Length;
                for (int i = 0; i < dl4; i++) // UTWORZENIE TAB INT Z 1 MACIERZY
                {
                    if (arr[i] != null)
                    {
                        arr4[i] = new int();
                        int el = Convert.ToInt32(arr[i].Text);
                        arr4[i] = el;
                    }
                }
                for (int i = 0; i < dl5; i++) // UTWORZENIE TAB INT Z 2 MACIERZY
                {
                    if (arr2[i] != null)
                    {
                        arr5[i] = new int();
                        int el = Convert.ToInt32(arr2[i].Text);
                        arr5[i] = el;
                    }
                }
                Class1 cls2 = new Class1();

                cls2.OdejmowanieMacierzy(arr4, arr5, arr6); // SUMOWANIE i WYPELNIENIE TRZECIEJ TAB INT
                for (int i = 0; i < dl4; i++) // PRZEKONWERTOWANIE TAB TXT NA INT
                {
                    arr3[i] = new TextBox();
                    string wynik = Convert.ToString(arr6[i]);
                    arr3[i].Text = wynik;
                }
                for (int j = 0; j < b; j++) // UTWORZENIE WYPELNIONEJ MACIERZY
                {
                    for (int i = 0; i < a; i++)
                    {

                        var tbox = new TextBox();
                        this.Controls.Add(tbox);
                        arr3[o] = tbox;
                        arr3[o].Text = Convert.ToString(arr6[o]);
                        tbox.Width = 20;
                        tbox.Location = new Point(x, y);
                        x += 20;
                        o += 1;
                    }
                    y += 20;
                    x = 100;
                }
            }catch
            {
                MessageBox.Show("Bledne wypelnienie macierzy", "Wyskoczyl blad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

