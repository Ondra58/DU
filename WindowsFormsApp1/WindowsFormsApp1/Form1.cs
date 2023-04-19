using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int n = (int)numericUpDown1.Value;
                int[] pole = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int nahodne = rng.Next(1, 21);
                    pole[i] = nahodne;
                    listBox1.Items.Add(nahodne);
                }

                label1.Text = pole[0] + " na " + pole[5] + " = " + Math.Pow(pole[0], pole[5]);  
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Pro umocnění musí pole obsahovat alespoň 6 čísel!");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Příliš velké číslo :(");
            }
            catch (Exception)
            {
                MessageBox.Show("Chyba!");
            }
        }
    }
}
