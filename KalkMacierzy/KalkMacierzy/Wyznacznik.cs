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
    public partial class Wyznacznik : Form
    {
        [DllImport("KalkMacierzyLib.dll")]
        public static extern int WyznacznikMacierzy(int[] pierwsza, int a);
        
        TextBox[] arr = new TextBox[100];
        TextBox[] arr2 = new TextBox[100];
        TextBox[] arr3 = new TextBox[100];
        int[] arr4 = new int[100];
        int[] arr5 = new int[100];
        int[] arr6 = new int[100];
        public Wyznacznik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textWyznW.Text);
                if (a > 3.0 || a < 0.0)
                {
                    MessageBox.Show("Wymiar wiekszy niz 3, badz mniejszy niz 0", "Wyskoczyl blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int x = 10, x2 = 200;
                    int y = 100, y2 = 100;
                    int o = 0, p = 0;
                    for (int j = 0; j < a; j++) // TWORZENIE PIERWSZEJ PUSTEJ MACIERZY
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
                    button2.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Zly wymiar", "Wyskoczyl blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                int dl4 = arr.Length;
                for (int i = 0; i < dl4; i++) // UTWORZENIE TAB INT Z 1 MACIERZY
                {
                    if (arr[i] != null)
                    {
                        arr4[i] = new int();
                        int el = Convert.ToInt32(arr[i].Text);
                        arr4[i] = el;
                    }
                }
                int a = Convert.ToInt32(textWyznW.Text);

                Class1 cls = new Class1();
                int wynik = cls.WyznacznikMacierzy(arr4, a);
                textwynik.Text = Convert.ToString(wynik);
            }catch
            {
                MessageBox.Show("Zle wypelniona macierz","Wyskoczyl blad",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        }
    }

