using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Quadrado
    {
        private int d;
        private int area;

        public void SetDiagonal(int d)
        {
            this.d = d;
        }
        public int GetDiagonal() 
        {
            return this.d;

        }
        public int GetArea ()
        {
            return this.area;
        }
        
        public void calcularArea()
        {
            this.area = this.d * this.d / 2;
        }
    }
}
