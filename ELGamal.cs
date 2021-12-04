using System;

namespace Егор
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            Console.WriteLine("Введите p простое число ");
            int p = Convert.ToInt32(Console.ReadLine()); //rand.Next(1, 50);
            /*while (p % 3 == 0 || p % 5 == 0 || p % 2 == 0||p%7==0)
            {
                p = rand.Next(1, 50);
                if (p == 3 || p == 5 || p == 7)
                    break;
            }*/
            Console.WriteLine("Введите x < p");
            int x = Convert.ToInt32(Console.ReadLine()); //rand.Next(1, p);
            /*while (x % 3 == 0 || x % 5 == 0 || x % 2 == 0)
            {
                x = rand.Next(1, p);
            }*/
            Console.WriteLine("Введите k < p - 1 ");
            int g = 0, e = 0, k = Convert.ToInt32(Console.ReadLine()); //rand.Next(1, p);
            for (int i = 2; i < 100; i++)
            {
                double u = (Math.Pow(i, p - 1)) % p;
                if (u == 1 && i < p)
                {
                    g = i;
                    break;
                }
            }
            double y = (Math.Pow(g, x)) % p;
            char[] s = new char[100];
            Console.WriteLine("Вводите сообщение по буквам на русском языке");
            for (int j = 0; j < 100; j++)
            {

                s[j] = Convert.ToChar(Console.Read());
                if (s[j] == '.')
                {
                    e = j;
                    break;
                }
            }
            int r = 0;
            int[] mr = new int[e];
            for (int j = 0; j < e; j++)
            {
                switch (s[j])
                {
                    case 'А': r = 1; break;
                    case 'Б': r = 2; break;
                    case 'В': r = 3; break;
                    case 'Г': r = 4; break;
                    case 'Д': r = 5; break;
                    case 'Е': r = 6; break;
                    case 'Ё': r = 7; break;
                    case 'Ж': r = 8; break;
                    case 'З': r = 9; break;
                    case 'И': r = 10; break;
                    case 'Й': r = 11; break;
                    case 'К': r = 12; break;
                    case 'Л': r = 13; break;
                    case 'М': r = 14; break;
                    case 'Н': r = 15; break;
                    case 'О': r = 16; break;
                    case 'П': r = 17; break;
                    case 'Р': r = 18; break;
                    case 'С': r = 19; break;
                    case 'Т': r = 20; break;
                    case 'У': r = 21; break;
                    case 'Ф': r = 22; break;
                    case 'Х': r = 23; break;
                    case 'Ц': r = 24; break;
                    case 'Ч': r = 25; break;
                    case 'Ш': r = 26; break;
                    case 'Щ': r = 27; break;
                    case 'Ъ': r = 28; break;
                    case 'Ы': r = 29; break;
                    case 'Ь': r = 30; break;
                    case 'Э': r = 31; break;
                    case 'Ю': r = 32; break;
                    case 'Я': r = 33; break;
                }
                mr[j] = r;
            }
            double res;
            double a = Math.Pow(g, k) % p;
            Console.WriteLine("Зашифрованное сообщение: ");
            for (int i = 0; i < e; i++)
            {
                res = (Math.Pow(y, k) * mr[i]) % p;
                Console.Write("(" + a + "," + res + ")" + " ");
            }


        }
    }
}
