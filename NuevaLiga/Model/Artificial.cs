using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public class Artificial : Personaje
   {

        #region "Atributos"
       
        private string create;
       
        #endregion

        #region "Propiedades"
       
        public string Create
        {
            get { return create; }
            set { create = value; }
        }
        
        #endregion

        #region "Costructor"
        public Artificial()
            : base()
        {
            this.create = "Personaje Desconocido";
            
        }

        public Artificial(string agregar, string nuevaliga, string villano, string create)
            : base(agregar, nuevaliga, villano)
        {
            this.create = create;
           
        }
        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     
                     
                     "Personaje Artificial" + this.create;
        }

        public override bool Equals(object obj)
        {
            Artificial t = (Artificial)obj;
            bool result = false;

            if (this.create == t.create)
                

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
            return "Add: " + this.agregar  + "\n" +
                   "Liga: " + this.nuevaliga + "\n" +
                   "Enemigo: " + this.villano;
        }
        #endregion
    }
}