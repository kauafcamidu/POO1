using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numero num;
            num = new numero();

            Console.Write("Digite o primeiro número:");     
            num.SetN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o segundo número:");
            num.SetN2(int.Parse(Console.ReadLine()));


            if (num.GetN1() > num.GetN2())
                Console.WriteLine("O maior número é o primeiro:" + num.GetN1());
            else
                Console.WriteLine("O maior número é o segundo: " + num.GetN2());
        }

        }
    }

