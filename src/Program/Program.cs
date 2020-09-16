using System;

using elementos;
using hechizos;
using personajes;

namespace Main
{
    class Program
    {
        static void Main (string[] args)
        {
            var personaje1 = new Personajes ()
            {
                Nombre = "Gandalf",
                Raza = "Mago", //poner un int con un identificador que por ejemplo 1 = "Mago"
                Items = "Baston, tunica", //mirar si se puede hacer con array,
                Vida = 300,
                Ataque = 40,
                Defensa = 34,

            };

            var elemento1 = new Elementos ()
            {
                TipoDeObjeto = "Baston",
                Daño = 37,
                Armadura = 0,
            };

            var elemento2 = new Elementos ()
        {  
                TipoDeObjeto = "Tunica",
                Daño = 0,
                Armadura = 43,
            };//tony

        }
    }
}