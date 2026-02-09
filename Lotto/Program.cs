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

        static void Main(string[] args)
        {
            int [] nyeroszamok = LottoszamokGeneralasa();
        }
    }
}
