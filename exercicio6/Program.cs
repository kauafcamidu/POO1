using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milha mil;
            mil = new Milha();

            Console.Write("Digite o número de milhas marítimas:");
            mil.SetMilhasMaritimas(double.Parse(Console.ReadLine()));

            mil.CalcularQuilometros();
            
            Console.WriteLine("Milhas Marítimas: " + mil.GetMilhasMaritimas());
            Console.WriteLine("Quilômetros:" + mil.GetQuilometros());
            





        }
    }
}
