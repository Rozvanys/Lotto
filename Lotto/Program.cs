using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    internal class Program
    {
        static int[] LottoszamokGeneralasa()
        {
            Random rnd = new Random();
            int[] szamok = new int[5];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 91);
            }
            return szamok;
        }
        //static int[] SzamBekeres(int[] szamok)
        //    {
        //    int[] bekertSzamok = new int[5];
        //    for (int i = 0; i < bekertSzamok.Length; i++)
        //    {
        //        Console.WriteLine("Kérem adja meg a(z) {0}. számot: ", i + 1);
        //        bekertSzamok[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return bekertSzamok;
        //}
        static int[] Bekeresek()
        {
            int[] tippek = new int[5];
            int i = 0;
            while (i < tippek.Length)
            {
                Console.WriteLine("Kérem a tippet: ");
                int tipp = Convert.ToInt32(Console.ReadLine());
                bool vanE = false;
                for (int j = 0; j < i; j++)
                {
                    if (tippek[j] == tipp)
                    {
                        vanE = true;
                    }
                }
                if (!vanE)
                {
                    tippek[i] = tipp;
                    i++;
                }
                else
                {
                    Console.WriteLine("Ez a szám már szerepel a tippek között, kérem adjon meg egy másik számot!");
                }
                
            }
            return tippek;


        }
        static void kiir(int[] tomb)
        {
            for (int i = 0; (i) < tomb.Length; (i)++)
            {
                Console.WriteLine(tomb[i]+" ");
            }
            Console.WriteLine();
        }
        static void TalalatokSzama(int[] nyeroSzamok, int[] tippek)
        {
            int db = 0;
            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroSzamok.Length; j++)
                {
                    if (tippek[i] == nyeroSzamok[j])
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine($"Találatok száma: {db}");
        }

static void Main(string[] args)
        {
            int[] nyeroszamok = LottoszamokGeneralasa();
            int[] tippek = Bekeresek();
            kiir(nyeroszamok);
            kiir(tippek);
            TalalatokSzama(nyeroszamok, tippek);

        }
    }
}
