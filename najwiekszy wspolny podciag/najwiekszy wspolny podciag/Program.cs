using System;

namespace najwiekszy_wspolny_podciag
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abaabbaaa";
            string s2 = "babab";
            var Wynik = Macierz(s1, s2);
            Console.WriteLine(Powrot(Wynik, s1, s2, s1.Length, s2.Length));
            Console.WriteLine(Powrot2(Wynik, s1, s2, s1.Length, s2.Length));
        }
        static int[,] Macierz(string s1, string s2)
        {
            int[,] Wynik = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i-1] == s2[j-1])
                    {
                        Wynik[i, j] = Wynik[i - 1, j - 1] + 1;

                    }
                    else
                    {
                        if (Wynik[i - 1, j] > Wynik[i, j - 1])
                        {
                            Wynik[i, j] = Wynik[i - 1, j];
                        }
                        else
                        {
                            Wynik[i, j] = Wynik[i, j - 1];
                        }
                    }
                }
            }
            return Wynik;
        }
        static string Powrot(int[,]Wynik,string s1,string s2,int i, int j)
        {
            if(i==0|| j==0)
            {
                return "";
            }
            else if(s1[i-1]==s2[j-1])
            {
                return Powrot(Wynik, s1, s2, i - 1, j - 1) + s1[i - 1];
            }
            else if(Wynik[i,j-1]>Wynik[i-1,j])
            {
                return Powrot(Wynik, s1, s2, i, j - 1);
            }
            else
            {
                return Powrot(Wynik, s1, s2, i - 1, j);
            }

        }
        static string Powrot2(int[,]Wynik,string s1,string s2,int i, int j)
        {
            if (i == 0 || j == 0)
            {
                return "";
            }
            else if (s1[i - 1] == s2[j - 1])
            {
                return Powrot(Wynik, s1, s2, i - 1, j - 1) + s1[j - 1];
            }
            else if (Wynik[i, j - 1] > Wynik[i - 1, j])
            {
                return Powrot(Wynik, s1, s2, i-1, j);
            }
            else
            {
                return Powrot(Wynik, s1, s2, i, j-1);
            }
        }

    }
}
