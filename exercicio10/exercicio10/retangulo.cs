﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    internal class retangulo
    {
        private int b;
        private int h;
        private int area;

        public void setBase(int b)
        {
            this.b = b;
        }
        public int getBase()
        {
            return this.b;
        }
        public void setAltura(int h)
        {
            this.h = h;
        }
        public int getAltura()
        {
            return this.h;
        }
        public int getArea()
        {
            return this.area;
        }
        public void calcularArea()
        {
            this.area = this.b * this.h;
        }


    }
}
