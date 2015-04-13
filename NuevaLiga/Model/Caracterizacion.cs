using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public class Caracterizacion
    {
           
        #region "Atributos"
        private string namesuperherues;
        private string alias;
        private string planeta;
        private string genero;
        private string debilidad;
        private string habilidad;
        private double peso;
        private double tamaño;
        #endregion

        #region "Propiedades"
        public string NameSuperHerue
        {
            get { return namesuperherues; }
            set { namesuperherues = value; }
        }
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        public string Planeta
        {
            get { return planeta; }
            set { planeta = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Debilidad
        {
            get { return debilidad; }
            set { debilidad = value; }
        }

        public string Habilidad
        {
            get { return habilidad; }
            set { habilidad = value; }
        }
       
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        #endregion

        #region "Costructor"
        public Caracterizacion() 
        {
            this.namesuperherues = "Nombre Del Personaje";
            this.alias = "Alias Del Personaje";
            this.planeta = "Lugar De Origen Del Personaje";
            this.genero = "Genero Del Personaje";
            this.habilidad = "Habilidad Especial Del Personaje";
            this.debilidad = "Debilidad Del Personaje";
            this.peso = 333.4;
            this.tamaño = 45.4;
            
        }

        public Caracterizacion(string namesuperherues, string alias, string planeta, string genero,string habilidad,
            string debilidad,double peso, double tamaño)
        {
            this.namesuperherues = namesuperherues;
            this.alias = alias;
            this.planeta = planeta;
            this.genero = genero;
            this.habilidad = habilidad;
            this.debilidad = debilidad;
            this.peso = peso;
            this.tamaño = tamaño;
        }

        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +

                     "Name Del Personaje:  " + this.namesuperherues + "\n" +
                     "Alias Del Personaje:  " + this.alias + "\n" +
                     "Planeta Del Personaje:  " + this.planeta + "\n" +
                     "Genero Del Personaje:  " + this.genero + "\n" +
                     "Debilidad Del Personaje:  " + this.debilidad+ "\n" +
                     "Habilidad Del Personaje:  " + this.habilidad + "\n" +
                     "Peso Del Personaje:  " + this.peso + "\n" +
                     "Tamaño Del personaje" + this.tamaño;
        }

        public override bool Equals(object obj)
        {
            Caracterizacion z = (Caracterizacion)obj;
            bool result = false;

            if ((this.namesuperherues == z.namesuperherues) &&
                (this.alias == z.alias) &&
                (this.planeta == z.planeta) &&
                (this.genero == z.genero) &&
                (this.habilidad == z.habilidad) &&
                (this.debilidad == z.debilidad) &&
                (this.peso == z.peso) &&
                (this.tamaño == z.tamaño))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}