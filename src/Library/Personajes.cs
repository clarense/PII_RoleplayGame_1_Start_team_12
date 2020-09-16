using System;
using System.Collections.Generic;
using elementos;

namespace personajes
{
    public class Personajes
    {
        public string Nombre { get; set; }
        private string raza;
        public string Raza
        {
            get
            {
                string texto = "";
                switch(Raza)
                {
                    case "1":
                        texto = "Mago";
                        break;
                    case "2":
                        texto = "Elfo";
                        break;
                    case "3":
                        texto = "Enano";
                        break;
                }
                return texto;
            }
            set
            {
                switch(raza)
                {
                    case "Mago":
                    case "mago":
                    case "1":
                        value = "1";
                        break;
                    case "Elfo":
                    case "elfo":
                    case "2":
                        value = "2";
                        break;
                    case "Enano":
                    case "enano":
                    case "3":
                        value = "3";
                        break;
                }
            }
        }
        private Elementos item;
        public List<Elementos> Items
        {
            get
            {
                return this.Items;
            }
            set
            {
                List<string> ItemsEquipables = null;
                switch(Raza)
                {
                    case "1":
                        ItemsEquipables = new List<string>() {"Tunica", "Baston"};
                        break;
                    case "2":
                        ItemsEquipables = new List<string>() {"Arco", "Armadura ligera"};
                        break;
                    case "3":
                        ItemsEquipables = new List<string>() {"Hacha", "Armadura"};
                        break;
                }
                if(ItemsEquipables.Contains(item.TipoDeObjeto))
                {
                    bool equipped = false;
                    foreach(Elementos objeto in Items)
                    {
                        if(objeto.TipoDeObjeto == item.TipoDeObjeto)
                        {
                            Items.Remove(objeto);
                            Items.Add(item);
                            equipped = true;
                            break;
                        }
                    }
                    if (!equipped)
                    {
                        Items.Add(item);
                    }
                }
            }
        }
        private int vida;
        public int Vida
        {
            get
            {
                return this.Vida;
            }
            set
            {
                if (vida<1)
                {
                    value = 1;
                }
                else
                {
                    value = vida;
                }
            }
        }
        private int ataque;
        public int Ataque
        {
            get
            {
                return this.Ataque;
            }
            set
            {
                if (ataque<1)
                {
                    value = 1;
                }
                else
                {
                    value = ataque;
                }
            }
        }
        private int defensa;
        public int Defensa
        {
            get
            {
                return this.Defensa;
            }
            set
            {
                if (defensa<0)
                {
                    value = 0;
                }
                else
                {
                    value = defensa;
                }
            }
        }
    }
}