using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Aresta
    {
        private int a;
        private int area;

        public void SetAresta(int a)
        {
            this.a = a;

        }

        public int GetAresta()
        {
            return this.a;
        }
       public int GetArea()
       {
            return this.area;
       }

        public void calcularArea()
        {
            this.area = this.a * this.a;
        }
    }
}
