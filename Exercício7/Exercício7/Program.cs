using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dólar dol;
            dol = new Dólar();

            Console.Write("Digite a cotação do dólar: ");
            dol.SetCotacaoDolar(double.Parse(Console.ReadLine()));  
            
            Console.Write("Digite a quantidade de dólares: ");
            dol.SetQuantidadeDeDolares(double.Parse(Console.ReadLine()));

          
            dol.CalcularReais();

            
            Console.WriteLine($"Cotação do Dólar: {dol.GetCotacaoDolar()}");
            Console.WriteLine($"Quantidade de Dólares: {dol.GetQuantidadeDeDolares()}");
            Console.WriteLine($"Valor em Reais: R$ {dol.GetValorEmReais()}");
        }


    }
    }
