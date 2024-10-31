using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aresta are;
            are = new Aresta();

            Console.Write("Informe o valor da aresta do quadrdo");
            are.SetAresta(int.Parse(Console.ReadLine()));

           are.calcularArea();
            Console.WriteLine("Área do quadrado: {0}", are.GetArea());

        }
    }
}
