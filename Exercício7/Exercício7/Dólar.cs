using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    internal class Dólar
    {
        private double cotacaoDolar;
        private double valorEmReais;
        private double quantidadeDeDolares;

     
        public void SetCotacaoDolar(double cotacaoDolar)
        {
            this.cotacaoDolar = cotacaoDolar;
        }

        public void SetQuantidadeDeDolares(double quantidadeDeDolares)
        {
            this.quantidadeDeDolares = quantidadeDeDolares;
        }

      
        public double GetCotacaoDolar()
        {
            return this.cotacaoDolar;
        }

        public double GetValorEmReais()
        {
            return this.valorEmReais;
        }

        public double GetQuantidadeDeDolares()
        {
            return this.quantidadeDeDolares;
        }

        public void CalcularReais()
        {
            this.valorEmReais = this.quantidadeDeDolares * this.cotacaoDolar;
        }
    } 
}
