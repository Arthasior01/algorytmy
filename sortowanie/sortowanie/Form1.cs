using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sb_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 5, 2, 3, 4, 5, 1, 2, 3, 1, 23, 4, 5, 2, 2, 12, 3, 6, 8, 3, 32, 12, 312, 6, 21, 90 };
            MessageBox.Show(string.Join(" ", tab));

            tab = SortowanieB(tab);

            MessageBox.Show(string.Join(" ", tab));

        }
        int[]SortowanieB(int[] tab)
        {
            bool czyBylaZmiana = false;
            do
            {
                czyBylaZmiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        czyBylaZmiana = true;
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
            } while (czyBylaZmiana);

            return tab;
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 1,412,3,12,51,23,1,51,2,31,25,12,4,2326,3,7,32,431,4,16,347,3,3,4,2,534,7,3,23,42,362,2734};
            MessageBox.Show(string.Join(" ", tab));

            tab = SortowanieI(tab);

            MessageBox.Show(string.Join(" ", tab));
        }
        int[] SortowanieI(int[] tab)
        {
            int x = tab.Length;
            for(int i = 0; i < x-1; i++)
            {
                int klucz = tab[i];
                int j = i - 1;
                while (j >=0 && tab[j] > klucz)
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;
                }
                tab[j + 1] = klucz;

            }

            return tab;
        }

        private void btn_ss_Click(object sender, EventArgs e)
        {
            int[] tab = {12,32,321,3124,123,124,123,123,125,125,121,212,2,1,2,3,5,2,1,2,45,6,9,5,3,2,6,7,9,5,2};
            MessageBox.Show(string.Join(" ", tab));

            tab = SortowanieS(tab);

            MessageBox.Show(string.Join(" ", tab));
        }
        int[] SortowanieS(int[] tab)
        {
            int x = tab.Length;
            for( int i = 0; i < x-1; i++)
            {
                int min = i;
                for(int j = i + 1; j < x; j++)
                {
                    if(tab[j]<tab[min])
                    {
                        min = j;
                    }
                }
                int temp = tab[min];
                tab[min] = tab[i];
                tab[i] = temp;
            }

            return tab;
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            int[] tab = {1,2,4,2,1,8,3,343,6,23,6,3,223,8,432,43,12,53,2,3,5,7,54 };
            MessageBox.Show(string.Join(" ", tab));

            tab = SortowanieS(tab);

            MessageBox.Show(string.Join(" ", tab));
        }
        int[] SortowanieC(int[] tab)
        {
            int[] Sorttab = new int[tab.Length];

            int min = tab[0];
            int max = tab[0];

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
                else
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }
            int[] counts = new int[max - min + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                counts[tab[i] - min]++;

            }
            counts[0]--;
            for (int i = 1; i < tab.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                Sorttab[counts[tab[i] - min]--] = tab[i];
            }
            return Sorttab;
        }
    }
}
