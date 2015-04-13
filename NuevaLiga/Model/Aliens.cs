using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public class Aliens : Personaje

    {

        #region "Atributos"
       
        private string especie;
       
        #endregion

        #region "Propiedades"
       
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        
        #endregion

        #region "Costructor"
        public Aliens()
            : base()
        {
            this.especie = "rara";
            
        }

        public Aliens(string agregar, string nuevaliga, string villano, string especie)
            : base( agregar,  nuevaliga,  villano)
        {
            this.especie = especie;
           
        }
        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     
                     
                     "Especie Del personaje" + this.especie;
        }

        public override bool Equals(object obj)
        {
            Aliens a = (Aliens)obj;
            bool result = false;

            if (this.especie == a.especie)
                

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region "Metodos Abstracto"
        public override string Ifichas()
        {
            return "Add: " + this.agregar+ "\n" +
                   "Liga: " + this.nuevaliga + "\n" +
                   "Enemigo: " + this.villano;
        }
        #endregion
    }
}