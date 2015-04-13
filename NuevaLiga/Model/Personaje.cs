using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public abstract class Personaje
    {
        #region "Atributos"
        private Caracterizacion namesuperherues;
        private Caracterizacion alias;
        private Caracterizacion planeta;
        private Caracterizacion genero;
        private Caracterizacion debilidad;
        private Caracterizacion habilidad;
        private Caracterizacion peso;
        private Caracterizacion tamaño;
       
        public string agregar;
        public string nuevaliga;
        public string villano;
        #endregion

        #region "Propiedades"
        public string Agregar
        {
            get { return agregar; }
            set { agregar = value; }
        }
        public string Liga
        {
            get { return nuevaliga; }
            set { nuevaliga = value; }
        }
        public string Enemigo
        {
            get { return villano; }
            set { villano = value; }
        }
        
        
        #endregion

        #region "Costructores"
        public Personaje()
        {
            this.namesuperherues = new Caracterizacion();
            this.alias = new Caracterizacion();
            this.planeta = new Caracterizacion();
            this.genero = new Caracterizacion() ;
            this.habilidad = new Caracterizacion();
            this.debilidad = new Caracterizacion();
            this.peso = new Caracterizacion();
            this.tamaño = new Caracterizacion();
            this.agregar = "Tipo de caraterisacion";
            this.nuevaliga = "Liga del personage";
            this.villano = "Enenigo del personage";
        }

        public Personaje( string agregar, string nuevaliga, string villano)
        {
            this.namesuperherues = new Caracterizacion();
            this.alias = new Caracterizacion();
            this.planeta = new Caracterizacion();
            this.genero = new Caracterizacion();
            this.habilidad = new Caracterizacion();
            this.debilidad = new Caracterizacion();
            this.peso = new Caracterizacion();
            this.tamaño = new Caracterizacion();
            this.agregar = agregar;
            this.nuevaliga = nuevaliga;
            this.villano = villano;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Name Del Personaje:  " + this.namesuperherues + "\n" +
                     "Alias Del Personaje" + this.alias + "\n" +
                     "Planeta De Origen: " + this.planeta + "\n" +
                     "Genero Del Personaje" + this.genero + "\n" +
                     "Debilidad Del Personaje: " + this.debilidad + "\n" +
                     "Habilidad Del Personaje" + this.habilidad + "\n" +
                     "Peso Del Personaje" + this.peso + "\n" +
                     "Tamaño Del personaje: " + this.tamaño;
        }

        public override bool Equals(object obj)
        {
            Personaje p = (Personaje)obj;
            bool result = false;

            if ((this.namesuperherues == p.namesuperherues) &&
                (this.alias == p.alias) &&
                (this.planeta == p.planeta) &&
                (this.genero == p.genero) &&
                (this.habilidad == p.habilidad) &&
                (this.debilidad == p.debilidad) &&
                (this.peso == p.peso) &&
                (this.tamaño == p.tamaño))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion

        #region "Metodos Abstracto"

        public abstract string Ifichas();
        

        #endregion
    }
}