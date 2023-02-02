using System;
using System.Net.NetworkInformation;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Square();
                    break;
                case "2":
                    Diamond();
                    break;
                case "3":
                    Retangle();
                    break;
                case "4":
                    Triangle();
                    break;
                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }


        private static void Square()
        {
            Console.WriteLine("Sisesta külg:");
            decimal side = Convert.ToDecimal(Console.ReadLine());
            decimal ümbermööt = 4 * side;
            Console.WriteLine("Ümbermõõt on : " + ümbermööt);

            decimal pindala = side * side;
            Console.WriteLine("Pindala on: " + pindala);

            Console.WriteLine("Sisesta kujundi suurus");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
        private static void Diamond()
        {
            Console.WriteLine("Sisesta ringi raadius");
            double side = Convert.ToDouble((Console.ReadLine()));
            double raadius =  Math.PI * side;
            Console.WriteLine("Ringi ümbermõõt on: " + raadius);

            double pindala = Math.PI * Math.Sqrt(raadius);
            Console.WriteLine("Ringi pindala on : " + pindala);
            Console.WriteLine("Sisesta teemandi suurus");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
        private static void Retangle()
        {

            Console.WriteLine("Ristkülik");
            Console.Write("Sisesta ristküliku esimene külg : ");
            decimal Length = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Sisesta ristküliku teine külg : ");
            decimal Width = Convert.ToDecimal(Console.ReadLine());
            decimal Perimeter = 2 * (Length + Width);
            Console.Write("Ümbermõõt on : " + Perimeter);
 
            Console.WriteLine("Sisesta kujundi suurus");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                for (int x = 0; x < 10; x++)
                    {
                    string mark;
                    if (row == row || row + row <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
        private static void Triangle()
        {
            Console.WriteLine("Sisesta kolm nurga külg:");
            decimal side = Convert.ToDecimal(Console.ReadLine());
            decimal ümbermööt = side + side + side;
            Console.WriteLine("Ümbermõõt on : " + ümbermööt);
          
            Console.WriteLine("Sisesta kolmnurga kõrgus");
            decimal kõrgus = Convert.ToDecimal(Console.ReadLine());
            decimal pindala = side * kõrgus / 2;
            Console.WriteLine("Pindala on: " + pindala);

            Console.WriteLine("Sisesta kolmnurga suurus");
            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }
        }
    }  
}

