﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO1
{
    internal class Soma
    {
        internal class Program
        {
            static void Main(string[] args)
            { }
            private int b;
            private int h;
            private int area;
            public void setBase(int b)
            {
                this.b = b;
            }
            public void setAltura(int h)
            {
                this.h = h;
            }
            public int getBase()
            {
                return this.b;
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
}


    

