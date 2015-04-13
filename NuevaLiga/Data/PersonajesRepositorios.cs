using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NuevaLiga.Model;
using NuevaLiga.Data;

namespace NuevaLiga.Data
{
    public class PersonajesRepositorios
    {
        private static List<Personaje> personas = new List<Personaje>();
        private static List<Caracterizacion> data = new List<Caracterizacion>();

        Caracterizacion datos  = new Caracterizacion ("azumi","azumoto","nixomato","no identificado","golpe de puño","no come", 33.3, 45.5);

        public PersonajesRepositorios()
        {
            data.Add(datos);
        }

        public IEnumerable<Personaje> getPersonaje()
        {
            Humanos agregacion1 = new Humanos("agregar", " nuevaliga", "villano","armamento", "armadura");
            Aliens agregacion2 = new Aliens("agregar", " nuevaliga", "villano","especie");
            Artificial agregacion3 = new Artificial("agregar", " nuevaliga", "villano", "create");
            SuperHumanos agregacion4 = new SuperHumanos("agregar", " nuevaliga", "villano", "combinacion");

            personas.Add(agregacion1);
            personas.Add(agregacion2);
            personas.Add(agregacion3);
            personas.Add(agregacion4);

            return personas;
        }

        public void AddCaraterizacion(Caracterizacion z) 
        {
            data.Add(z);
        }

        public IEnumerable<Caracterizacion> getData() 
        {
            return data;   
        }


        
    }  
}
