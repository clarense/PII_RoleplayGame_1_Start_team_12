using System;
using personajes;

namespace hechizos
{
    public class Hechizos
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Daño { get; set; }
        public string Descripcion { get; set; }

        public void Usar(Personajes mago, Personajes objetivo)
        {
            if(mago.Raza == "1")
            {
                objetivo.Vida -= this.Daño;
            }
        }
    }
}
