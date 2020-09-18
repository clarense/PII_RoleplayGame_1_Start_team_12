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
                return this.raza;
            }
            set
            {
                switch(value)
                {
                    case "Mago":
                    case "mago":
                    case "1":
                        raza = "1";
                        break;
                    case "Elfo":
                    case "elfo":
                    case "2":
                        raza = "2";
                        break;
                    case "Enano":
                    case "enano":
                    case "3":
                        raza = "3";
                        break;
                }
            }
        }
        private List<Elementos> items = new List<Elementos>();
        public List<Elementos> Items
        {
            get
            {
                return this.items;
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
                        ItemsEquipables = new List<string>() {"Arco", "Armadura ligera", "RPG", "Escudito"};
                        break;
                    case "3":
                        ItemsEquipables = new List<string>() {"Hacha", "Armadura"};
                        break;
                }
                bool equipped = false;
                foreach(Elementos objeto in value)
                {
                    if(ItemsEquipables.Contains(objeto.TipoDeObjeto))
                    {
                            foreach(Elementos item in Items)
                            {
                                if(objeto.TipoDeObjeto == item.TipoDeObjeto)
                                {
                                    items.Remove(item);
                                    items.Add(objeto);
                                    equipped = true;
                                    break;
                                }
                            }
                    }
                    if (!equipped)
                    {
                        items.Add(objeto);
                    }
                }
            }
        }
        public int vidatotal;
        private int vida;
        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                if (value<1)
                {
                    vida = 1;
                }
                else
                {
                    vida = value;
                }
                vidatotal = vida;
            }
        }
        private int ataque;
        public int Ataque
        {
            get
            {
                return this.ataque;
            }
            set
            {
                if (value<1)
                {
                    ataque = 1;
                }
                else
                {
                    ataque = value;
                }
            }
        }
        private int defensa;
        public int Defensa
        {
            get
            {
                return this.defensa;
            }
            set
            {
                if (value<0)
                {
                    defensa = 0;
                }
                else
                {
                    defensa = value;
                }
            }
        }

        //AtaqueTotal representa el Ataque del personaje más el daño de todos sus items.
        public int AtaqueTotal()
        {
            int ataque = this.Ataque;
            foreach(Elementos item in Items)
            {
                ataque += item.Daño;
            }
            return ataque;
        }
        
        //DefensaTotal representa la Armadura Total, incluye la defensa del personaje mas la de todos sus items.
        public int DefensaTotal()
        {
            int defensa = this.Defensa;
            foreach(Elementos item in Items){
                defensa += item.Armadura;
            }
            return defensa;
        }
    
        //Atacar realiza un ataque sobre el personaje Objetivo teniendo en cuenta la armadura de la unidad.
        public void Atacar(Personajes objetivo)
        {
                objetivo.Vida -= Convert.ToInt32(this.AtaqueTotal() * (1 - 0.1*objetivo.DefensaTotal()/30));
        }

        public void CurarTotal()
        {
            this.Vida = this.vidatotal;
        }

    }
}