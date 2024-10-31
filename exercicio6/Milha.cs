using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Milha
    {
        private double milhasMaritimas;
        private double Quilometros;

        public void SetMilhasMaritimas(double milhasMaritimas)
        {
            this.milhasMaritimas = milhasMaritimas;
            
        }
        public double GetMilhasMaritimas()
        {
            return this.milhasMaritimas;
        }
        public double GetQuilometros()
        {
            return this.Quilometros;
        }
        public void CalcularQuilometros()
        {
            this.Quilometros = this.milhasMaritimas * 1.852;
        }
    }
}
