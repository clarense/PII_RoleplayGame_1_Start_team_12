using System;
using System.Collections.Generic;

namespace elementos
{
    public class Elementos
    {
        public string TipoDeObjeto { get; set; }
        private int daño;
        public int Daño
        {
            get
            {
                return this.daño;
            }
            set
            {
                if (value<0)
                {
                    daño = 0;
                }
                else
                {
                    daño = value;
                }
            }
        }
        private int armadura;
        public int Armadura
        {
            get
            {
                return this.armadura;
            }
            set
            {
                if (value<0)
                {
                    armadura = 0;
                }
                else
                {
                    armadura = value;
                }
            }
        }

    }
}