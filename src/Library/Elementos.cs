using System;
using System.Collections.Generic;

namespace elementos
{
    public class Elementos
    {
        private string tipodeobjeto;
        public string TipoDeObjeto
        {
            get
            {
                return this.TipoDeObjeto;
            }
            set
            {
                List<string> Tipos = new List<string>() {"Túnica", "Bastón", "Arco", "Armadura ligera", "Hacha", "Armadura"};
                if (Tipos.Contains(tipodeobjeto))
                {
                    value = tipodeobjeto;
                }
            }
        }
        private int daño;
        public int Daño
        {
            get
            {
                return this.Daño;
            }
            set
            {
                if (daño<0)
                {
                    value = 0;
                }
                else
                {
                    value = daño;
                }
            }
        }
        private int armadura;
        public int Armadura
        {
            get
            {
                return this.Armadura;
            }
            set
            {
                if (armadura<0)
                {
                    value = 0;
                }
                else
                {
                    value = armadura;
                }
            }
        }

    }
}