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
<<<<<<< Updated upstream
                List<string> Tipos = new List<string>() {"Tunica", "Baston", "Arco", "Armadura ligera", "Hacha", "Armadura","RPG","Escudito"};
=======
                List<string> Tipos = new List<string>() {"Tunica", "Baston", "Arco", "Armadura ligera", "Hacha", "Armadura", "RPG", "Escudito"};
>>>>>>> Stashed changes
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