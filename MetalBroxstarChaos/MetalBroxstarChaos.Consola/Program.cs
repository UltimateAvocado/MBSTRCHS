using System;
using MetalBroxstarChaos.Datos;

namespace MetalBroxstarChaos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            //MetodosContexto.PostPersonaje(new Modelos.Personaje {
            //    idPersonaje = 1,
            //    nombrePersonaje = "Pepe el Paladin",
            //    nivelPersonaje = 1,
            //    idClase = 3
            //});
            
            //var personaje = MetodosContexto.GetPersonaje(1);
            var resultado = MetodosContexto.GetClases();
            
            foreach(var res in resultado)
            {
                Console.WriteLine(res.nombreClase);
            }

            var resultado2 = MetodosContexto.GetPersonaje(1);

            Console.WriteLine(resultado2.nombrePersonaje + "Profesión -"+ resultado2.clase.nombreClase);

        }
    }
}
