using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado qua;
            qua = new Quadrado();

            Console.Write("Informe o valor da diagonaldo quadrado");
            qua.SetDiagonal(int.Parse(Console.ReadLine()));

            qua.calcularArea();

            Console.WriteLine("Área do Quadrado:{0}", qua.GetArea());
        }
    }
}
