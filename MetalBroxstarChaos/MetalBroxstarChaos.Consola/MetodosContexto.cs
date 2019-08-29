using System;
using System.Collections.Generic;
using MetalBroxstarChaos.Datos;
using MetalBroxstarChaos.Modelos;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MetalBroxstarChaos.Consola
{
    public class MetodosContexto
    {


        public static Personaje GetPersonaje(int Id)
        {

            using (var _context = new BroxstarContext())
            {
                var personaje = _context.Personajes
                    .Include(x => x.clase).FirstOrDefault();

                //cuantos regresara
                return personaje;
            }

        }

        public static void PostPersonaje(Personaje personaje)
        {

            using (var _context = new BroxstarContext())
            {
                _context.Personajes.Add(personaje);
                //guardar Cambios
                _context.SaveChanges();
            }

        }


        public static List<Clase> GetClases()
        {
            try
            {

                using (var _context = new BroxstarContext())
                {
                    var Clases = _context.Clases.ToList();

                    return Clases;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
