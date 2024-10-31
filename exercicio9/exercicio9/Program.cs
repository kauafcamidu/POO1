using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numeromaior num;
            num = new numeromaior();

            Console.Write("Digite o primeiro valor:");
            num.SetN1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o segundo valor:");
            num.SetN2(int.Parse(Console.ReadLine()));

            if(num.GetN1() == num.GetN2())
            {
                Console.WriteLine("Os números são iguais");
            }
            if (num.GetN1() > num.GetN2())
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else
            {
                Console.WriteLine("O segundo número é maior");
            }
        }
    }
}
