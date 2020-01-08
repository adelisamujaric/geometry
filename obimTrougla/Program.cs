using System;

namespace obimTrougla
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part one
            Console.WriteLine("Ovaj program racuna obim trougla!");

            Console.WriteLine("Unesite stranicu a: ");
            string num1 = Console.ReadLine();
            int a = Convert.ToInt32(num1);
            
            Console.WriteLine("Unesite stranicu b: ");
            string num2 = Console.ReadLine();
            int b = Convert.ToInt32(num2);

            Console.WriteLine("Unesite stranicu c: ");
            string num3 = Console.ReadLine();
            int c = Convert.ToInt32(num3);

            int obimTrougla = a + b + c;

            Console.WriteLine("Obim trougla iznosi " + obimTrougla + ".\n\n");


            //Part 2
            Console.WriteLine("Ovaj program racuna obim i povrsinu kruga!");

            Console.WriteLine("Unesite poluprecnik kruga: ");
            string num4 = Console.ReadLine();
            double r = Convert.ToDouble(num4);

            double pi = 3.14;

            double povrsinaKruga = r * r * pi;
            double obimKruga = 2 * r * pi;

            Console.WriteLine("Povrsina kruga je " + povrsinaKruga + ", a obim kruga je " + obimKruga + ".\n\n");


            //Part 3
            Console.WriteLine("Ovaj program racuna zapreminu i povrsinu lopte!");

            Console.WriteLine("Unesite poluprecnik lopte: ");
            string num5 = Console.ReadLine();
            double rr = Convert.ToDouble(num5);

            double povrsinaLopte = 4*pi*rr*2;
            double zapreminaLopte = 4/3*rr*rr*rr*pi;

            Console.WriteLine("Povrsina lopte je " + povrsinaLopte + ", a zapremina lopte je " + zapreminaLopte + ".\n\n");

            //Part 4
            Console.WriteLine("Ovaj program racuna zapreminu i povrsinu kocke!");

            Console.WriteLine("Unesite stranicu kocke: ");
            string num6 = Console.ReadLine();
            double stranica = Convert.ToDouble(num6);

            double povrsinaKocke = 6 * stranica * stranica;
            double zapreminaKocke = stranica * stranica * stranica;

            Console.WriteLine("Povrsina kocke je " + povrsinaKocke + ", a zapremina kocke je " + zapreminaKocke + ".\n\n");

            //Part 5
            Console.WriteLine("Ovaj program racuna obim i povrsinu pravougaonika!");

            Console.WriteLine("Unesite prvu stranicu pravougaonika: ");
            string num7 = Console.ReadLine();
            double stranca1 = Convert.ToDouble(num7);

            Console.WriteLine("Unesite drugu stranicu pravougaonika: ");
            string num8 = Console.ReadLine();
            double stranica2 = Convert.ToDouble(num8);


            double povrsinaPravougaonika =stranca1*stranica2;
            double obimPravougaonika = 2 * stranca1 + 2 * stranica2;

            Console.WriteLine("Povrsina pravougaonika je " + povrsinaPravougaonika + ", a obim pravougaonika je " + obimPravougaonika + ".");




            Console.Read();
        }
    }
}
