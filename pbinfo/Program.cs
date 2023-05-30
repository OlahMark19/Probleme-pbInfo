using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exercitii PbInfo\nIntroduceti un numar de exercitiu: ");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
                case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    P12();
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;
                case "18":
                    P18();
                    break;
                case "19":
                    P19();
                    break;
                case "20":
                    P20();
                    break;
                   
            }
        }
        private static void P1()
        {
            Console.WriteLine("--- #813 - Globuri ---");
            Console.Write("Introduceti numarul globurilor albe: ");
            int albi = int.Parse(Console.ReadLine());
            int rosii = albi * 2;
            int verzi = rosii - 3;

            int total = albi + rosii + verzi;
            Console.WriteLine("Numarul total al globurilor sunt " + total);
            Console.ReadKey();
        }
        private static void P2()
        {
            Console.WriteLine("--- #3178 - Copii2 ---");
            Console.Write("Introduceti numarul fetelor: ");
            int F = int.Parse(Console.ReadLine());
            Console.Write("introduceti numarul baietilor: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul zilelor: ");
            int n = int.Parse(Console.ReadLine());

            int totalF = (F * 3) * n;
            int totalB = (B * 2) * n;

            int total = totalF + totalB;
            Console.WriteLine("Numarul total depigini citite in " + n + " zile sunt " + total);
            Console.ReadKey();
        }
        private static void P3()
        {
            Console.WriteLine("--- #2240 - Animale ---");
            Console.Write("Introduceti numarul cainilor din curte: ");
            int caini = int.Parse(Console.ReadLine());
            int pisici = caini * 2;
            int gaini = pisici * 2;

            int total = caini + gaini + pisici;
            Console.WriteLine("Numarul total de animale din curte sunt " + total);
            Console.ReadKey();
        }
        private static void P4()
        {
            Console.WriteLine("--- #3179 - Parc2 ---");
            Console.Write("Introduceti numarul aleelor: ");
            int n = int.Parse(Console.ReadLine());
            int alee = n;
            int arbori = alee * n;
            int crengi = arbori * n;
            int cuiburi = crengi * n;
            int pasari = cuiburi * n;

            Console.WriteLine("In parc sunt " + pasari + " pasari");
            Console.ReadKey();

        }
        private static void P5()
        {
            Console.WriteLine("--- #2263 - Camioane ---");
            Console.WriteLine("Știind că firma are n camioane de tipul 1 și m camioane de tipul 2,\ncâte tone de marfă pot transporta camioanele firmei în z zile.");
            Console.Write("Introduceti o valoare t1: ");
            int t1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare t2: ");
            int t2 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul camioanelor de tipul 1: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul camioanelor de tipul 2: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul zilelor: ");
            int z = int.Parse(Console.ReadLine());

            int ttct1 = n * t1;
            int ttct2 = m * t2;

            int tottranscam = ttct1 + ttct2;
            int ziletot = tottranscam * z;
            Console.WriteLine("In " + z + " zile camioanele transporta " + ziletot + " tone de marfa");
            Console.ReadKey();
        }
        private static void P6()
        {
            Console.Write("--- #814 - Triplul ---");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea y: ");
            int y = int.Parse(Console.ReadLine());

            int tripluy = y * 3;
            int xplus = tripluy - x;

            Console.Write(xplus);
            Console.ReadKey();
        }
        private static void P7()
        {
            Console.WriteLine("--- #3210 - Cumparaturi ---");
            Console.Write("Introduceti valorile B si S: ");
            string[] tokens = Console.ReadLine().Split(' ');
            int B = int.Parse(tokens[0]);
            int S = int.Parse(tokens[1]);       
            int counter = 0;

            if (S == B)
            {            
                Console.WriteLine($"Gigel poate cumpara o singura cutie cu bomboane, si mai are nevoie de {B} lei pentru a cumpara inca o cutie.");
            }
            else if (S > B)
            {
                while (S > B)
                {
                    S -= B;
                    counter++;
                }
                Console.WriteLine($"Gigel a ramas cu {S} lei si a cumparat {counter} cutii, mai are nevoie de {B - S} lei.");
            }
            else if (S < B)
            {
                Console.WriteLine($"Gigel nu are destui bani mai are nevoie de {B - S} lei.");
            }
            Console.ReadKey();
        }
        private static void P8()
        {
            Console.WriteLine("--- #3978 - sabc ---");
            Console.WriteLine("Introduceti trei numere a b c: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;

            for (int i = a; i <= b; i++)
            {
                s1 += i;     
            }
            for (int i = b; i <= c; i++)
            {
                s2 += i;
            }
            for (int i = a; i <= c; i++)
            {
                s3 += i;
            }
            
            Console.WriteLine($"s({a},{b}) = {s1}");
            Console.WriteLine($"s({b},{c}) = {s2}");
            Console.WriteLine($"s({a},{c}) = {s3}");
            Console.ReadKey();
        }
        private static void P9()
        {
            Console.WriteLine("--- #3180 - Marte1 ---");
            Console.Write("Introduceti valori pentru tipul de moneda a, b, c: ");
            string[] tokens = Console.ReadLine().Split(' ');

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);

            Console.Write("Introduceti valorile lui a, b, c: ");
            string[] tokenz = Console.ReadLine().Split(' ');

            int n = int.Parse(tokenz[0]);
            int m = int.Parse(tokenz[1]);
            int p = int.Parse(tokenz[2]);

            int va = a * n;
            int vb = b * m;
            int vc = c * p;

            int total = va + vb + vc;

            Console.WriteLine($"Iggle are {total} lei martieni.");
            Console.ReadKey();


        }
        private static void P10()
        {
            Console.WriteLine("--- #3182 - Marte2---");
            Console.Write("Introduceti cate zile dureaza anul martian: ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("Introduceti cate zile a trait: ");
            int n = int.Parse(Console.ReadLine());

            int l = n / z;

            Console.WriteLine($"Iggle are {l} lumanari pe tort.");
            Console.ReadKey();
        }
        private static void P11()
        {
            Console.WriteLine("--- #3181 - Marte3 ---");
            Console.Write("Cate zile dureaza un an martian: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Cate ore dureaza o zi martiana: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Cate antene va avea: ");
            int n = int.Parse(Console.ReadLine());

            int a = n / (x * y);
            n = n - a * x * y;
            int z = n / y;
            int h = n - z * y;

            Console.WriteLine("a = " + a);
            Console.WriteLine("z = " + z);
            Console.WriteLine("h = " + h);
            Console.ReadKey();

        }
        private static void P12()
        {
            Console.WriteLine("--- #815 - Lazi ---");
            Console.Write("Introduceti valoare laturii cutiilor: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea inaltimii din incapere: ");
            int h = int.Parse(Console.ReadLine());
            int counter = 0;
            int aux = 0;

            if (l < h)
            {
                while (l < h)
                {
                    aux = l * 2;
                    l = aux;
                    counter++;
                }
                Console.WriteLine((counter + 1) + " cutii incap in incapere.");
            }
            else if (l == h)
            {
                Console.WriteLine("O singura cutie incape in incapere.");
            }
            else if (l > h)
            {
                Console.WriteLine("Cutia nu incape in incapere.");
            }
            Console.ReadKey();
        }
        private static void P13()
        {
            Console.WriteLine("--- #175 - Picioare ---");
            Console.Write("Numarul de gaini = ");
            int G = int.Parse(Console.ReadLine());

            Console.Write("Numarul de oi = ");
            int O = int.Parse(Console.ReadLine());

            int cap = G + O;
            int picioare = (G * 2) + (O * 4);

            Console.WriteLine("Numarul de capete = " + cap);
            Console.WriteLine("Numarul de picioare = " + picioare);
            Console.ReadKey();
        }
        private static void P14()
        {
            Console.WriteLine("--- #2061 - Tren Japonez ---");
            Console.Write("Numarul vagoanelor = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Numarul de marfa totala = ");
            int m = int.Parse(Console.ReadLine());

            int I = m / n;
            Console.Write("Incarcatura = " + I);
            Console.ReadKey();

        }
        private static void P15()
        {
            Console.WriteLine("--- #2201 - Salut ---");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n * (n - 1) / 2);
            Console.ReadKey();
        }
        private static void P16()
        {
            Console.WriteLine("--- #2617 - Taieturi ---");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());

            int t = (n - 1) + (m - 1);

            Console.WriteLine(t + " taieturi totale.");
            Console.ReadKey();
        }
        private static void P17()
        {
            Console.Write("--- #2938 - Albina ---");
            Console.Write("\nNumarul de zile: ");
            int n = int.Parse(Console.ReadLine());

            int celule = 1;
            for (int i = 1; i <= n; i++)
            {
                celule += 6;
            }
            Console.WriteLine($"Dupa {n} zile albina a depus nectar in {celule} celule.");
            Console.ReadKey();
        }
        private static void P18()
        {
            Console.WriteLine("--- #2764 - InvertedColor ---");
            Console.Write("r = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("g = ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            r = 255 - r;
            g = 255 - g;
            b = 255 - b;

            Console.WriteLine(r + " " + g + " " + b);
            Console.ReadKey();
        }
        private static void P19()
        {
            Console.WriteLine("--- #2377 - Pisici ---");
            Console.WriteLine("Un numar n si m : ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine($"In {n} minute mananca {m} pisici {m} soareci.");
            Console.ReadKey();
        }
        private static void P20()
        {
            Console.WriteLine("--- #4185 - Varsta ---");
            Console.WriteLine("Trei numare a b c d cu space: ");
            string[] tokens = Console.ReadLine().Split(' ');

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);
            int d = int.Parse(tokens[3]);


        }

    }
}
