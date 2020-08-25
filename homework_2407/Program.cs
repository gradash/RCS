using System;
using System.Threading.Tasks.Dataflow;

namespace homework_2407
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            1) Uztaisīt metodi, kas paņem vienu int skaitli kā parametru un izvada kvadrātā.t.i.padodam,piemēram 3, tiek reizinats 3 * 3, izvada 9.
            2) Uztaisīt metodi, kur lietotājs ievada skaitli ar komatu.Pārkonvērtēt uz double un ar return atgriezt.
            3) Uztaisīt metodi, kur Jūs padodat skaitli, atņemt šim skaitlim 2, ar return atgriezt rezultātu.
            4) kā parametrus padot 3 string tipa vērtības un sakombinēt apgrieztā secībā.t.i.vērtība, kas padota pirmā,
            būs pēdējā, vēŗtība, kas padota pēdējā'būs pirmā. Piemēram-
            padod aa, bb un cc,
            Metode ar return atgriež ccbbaa
            */

            int x = Pow(4);
            Console.WriteLine(x);

            double a = ConvToDouble("1,6");
            Console.WriteLine(a);

            int y = MinusTwo(5);
            Console.WriteLine(y);

            string WordConvert = WordsCombine("aa", "bb", "cc");
            Console.WriteLine(WordConvert);
        }

        //1
        static int Pow(int x)
        {
            x = x * x;
            return x;
        }

        //2
        static double ConvToDouble(string x)
        {
            double y = Convert.ToDouble(x);
            return y;
        }

        //3
        static int MinusTwo(int x)
        {
            x = x - 2;
            return x;
        }

        //4
        static string WordsCombine(string aa, string bb, string cc)
        {
            string convert = cc + bb + aa;
            return convert;
        }


    }
}
