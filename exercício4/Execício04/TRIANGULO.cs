using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execício04
{
    internal class TRIANGULO
    {
        private int b;
        private int h;
        private int area;


        public void SetBase(int b)
        {
            this.b = b;
        }

        public void SetAltura(int h)
        {
            this.h = h;
        }

        public int GetBase()
        {
            return this.b;
        }

        public int GetAltura()
        {
            return this.h;
        }

        public int GetArea()
        {
            return this.area;
        }

        public void CalcularArea()
        {
            this.area = this.b * this.h / 2;
        }
    }
}
