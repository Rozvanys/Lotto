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
        static int[] SzamBekeres(int[] szamok)
            {
            int[] bekertSzamok = new int[5];
            for (int i = 0; i < bekertSzamok.Length; i++)
            {
                Console.WriteLine("Kérem adja meg a(z) {0}. számot: ", i + 1);
                bekertSzamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            return bekertSzamok;
        }

static void Main(string[] args)
        {
            int [] nyeroszamok = LottoszamokGeneralasa();
            Console.WriteLine("A nyerőszámok: {0}", string.Join(", ", nyeroszamok));
        }
    }
}
