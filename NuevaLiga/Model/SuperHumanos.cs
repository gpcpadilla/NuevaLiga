using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public class SuperHumanos : Personaje
    {

        #region "Atributos"
       
        private string combinacion;
       
        #endregion

        #region "Propiedades"
       
        public string CombinacionDeEspecies
        {
            get { return combinacion; }
            set { combinacion = value; }
        }
        
        #endregion

        #region "Costructor"
        public SuperHumanos()
            : base()
        {
            this.combinacion = "Personaje Desconocido";
            
        }

        public SuperHumanos(string agregar, string nuevaliga, string villano, string combinacion)
            : base(agregar, nuevaliga, villano)
        {
            this.combinacion = combinacion;
           
        }
        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     
                     
                     "Personaje Artificial" + this.combinacion;
        }

        public override bool Equals(object obj)
        {
            SuperHumanos s = (SuperHumanos)obj;
            bool result = false;

            if (this.combinacion == s.combinacion)
                

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
            return "Add: " + this.agregar + "\n" +
                   "Liga: " + this.nuevaliga + "\n" +
                   "Enemigo: " + this.villano;
        }
        #endregion
    }
}