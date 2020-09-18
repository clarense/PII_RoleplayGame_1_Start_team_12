using System;
using System.Collections.Generic;
using elementos;
using hechizos;
using personajes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var elemento1 = new Elementos()
            {
                TipoDeObjeto = "Baston",
                Daño = 37,
                Armadura = 0,
            };

            var elemento2 = new Elementos()
            {
                TipoDeObjeto = "Tunica",
                Daño = 0,
                Armadura = 43,
            };

            var personaje1 = new Personajes()
            {
                Nombre = "Gandalf",
                Raza = "Mago",
                Items = new List<Elementos>() { elemento1, elemento2 },
                Vida = 300,
                Ataque = 40,
                Defensa = 0,
            };//tony

            var elemento3 = new Elementos()
            {
                TipoDeObjeto = "Hacha",
                Daño = 38,
                Armadura = 0,
            };

            var elemento4 = new Elementos()
            {
                TipoDeObjeto = "Armadura",
                Daño = 0,
                Armadura = 45,
            };

            var personaje2 = new Personajes()
            {
                Nombre = "Claudio",
                Raza = "Enano",
                Items = new List<Elementos>() { elemento3, elemento4 },
                Vida = 350,
                Ataque = 250,
                Defensa = 60,
            };//Valentina

            var elemento5 = new Elementos()
            {
                TipoDeObjeto = "RPG",
                Daño = 60,
                Armadura = 0,
            };

            var elemento6 = new Elementos()
            {
                TipoDeObjeto = "Escudito",
                Daño = 0,
                Armadura = 70,
            };

            var personaje3 = new Personajes()
            {
                Nombre = "Tony",
                Raza = "Elfo",
                Items = new List<Elementos>() { elemento4, elemento5 },
                Vida = 270,
                Ataque = 80,
                Defensa = 75,
            };//Gonzalo

            var hechizo1 = new Hechizos()
            {
                Nombre = "Wingardium Leviosa",
                Tipo = "Daño",
                Daño = 65,
                Descripcion = "Eleva a su oponente y lo estrella contra el piso",
            };

            Console.WriteLine(personaje1.DefensaTotal());
            Console.WriteLine(personaje1.AtaqueTotal());
            Console.WriteLine(personaje1.Vida);
            personaje2.Atacar(personaje1);
            Console.WriteLine(personaje1.Vida);
            Console.WriteLine("gonza trolo");

        }
           

    }
}
