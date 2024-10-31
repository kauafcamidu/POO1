using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo ret;
            ret = new retangulo();

            Console.Write("Digite a Base do retangulo:");
            ret.setBase(int.Parse(Console.ReadLine()));

            Console.Write("Digite a altura do retangulo:");
            ret.setAltura(int.Parse(Console.ReadLine()));

            ret.calcularArea();

            Console.WriteLine("Área do retângulo: {0}", ret.getArea());

            if (ret.getArea() > 100)
                Console.WriteLine("Terreno Grande");
            else
                Console.WriteLine("Terreno Pequeno");




        }
    }
}
