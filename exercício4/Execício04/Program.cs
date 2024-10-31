using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TRIANGULO tri;
            tri = new TRIANGULO();

            Console.Write("Insira o valor da base do Triângulo:");
            tri.SetBase(int.Parse(Console.ReadLine()));

            Console.Write("Insira o valor da Altura do Triângulo:");
            tri.SetAltura(int.Parse(Console.ReadLine()));

            tri.CalcularArea();
            Console.WriteLine("Área do Triângulo é: {0}", tri.GetArea());





        }
    }
}
