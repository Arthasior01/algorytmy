using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace rekurencje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ms_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 5, 2, 3, 4, 5, 1, 2, 3, 1, 23, 4, 5, 2, 2, 12, 3, 6, 8, 3, 32, 12, 312, 6, 21, 90 };
            MessageBox.Show(string.Join(" ", tab));

            SortowanieM(tab);

            MessageBox.Show(string.Join(" ", tab));
        }
        static void SortowanieM(int[] tab)
        {
           int[] wynik = SortowanieM(tab, 0, tab.Length);
            Array.Copy(wynik, tab, wynik.Length);
        }

        static int[] SortowanieM(int[] tab, int start, int end)
        {
            //podzielenie
            if (end - start < 2)
                return new int[] { tab[start] };

            int middle = start + ((end - start) / 2);
            int[] left = SortowanieM(tab, start, middle);
            int[] right = SortowanieM(tab, middle, end);

            // sortowanie i scalanie
            int[] wynik = new int[left.Length + right.Length];

            int idxL = 0;
            int idxR = 0;
            int i = 0;

            for (; idxL < left.Length && idxR < right.Length; i++)
            {
                if (left[idxL] < right[idxR])
                {
                    wynik[i] = left[idxL];
                    idxL++;
                }
                else
                {
                    wynik[i] = right[idxR];
                    idxR++;
                }
            }

            // copy remaining elements
            while (idxL < left.Length)
                wynik[i++] = left[idxL++];

            while (idxR < right.Length)
                wynik[i++] = right[idxR++];

            return wynik;
        }

        private void btn_cf_Click(object sender, EventArgs e)
        {
            string n = Interaction.InputBox("Ktora cyfre ciagu wyznaczyć?");
            int x = Convert.ToInt32(n);
            MessageBox.Show(string.Join(" ", Convert.ToString(fibonnaci(x))));


        }
        static int fibonnaci(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            if (x == 0)
            {
                return 0;
            }
            return fibonnaci(x - 1) + fibonnaci(x - 2);
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("Podaj pierwsza liczbę");
            string b = Interaction.InputBox("Podaj druga liczbę");
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            MessageBox.Show(string.Join(" ", Convert.ToString(euklides(c, d))));
        }

        static int euklides(int c, int d)
        {
            while (c != d)
            {
                if (c > d)
                    c -= d;
                else
                    d -= c;
            }
            return c;

        }
    }
}
