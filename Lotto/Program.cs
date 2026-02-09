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
            int[] Szamok = new int[5];
            for (int i = 0; i < Szamok.Length; i++)
            {
                Szamok[i] = rnd.Next(1, 91);
            }
        }

        static void Main(string[] args)
        {
            int [] nyeroszamok = LottoszamokGeneralasa();
        }
    }
}
