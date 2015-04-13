using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaLiga.Model
{
    public class Humanos : Personaje
    {
        #region "Atributos"
       
        private string armamento;
        private string armadura;
        #endregion

        #region "Propiedades"
       
        public string Amamento
        {
            get { return armamento; }
            set { armamento = value; }
        }
        public string Armadura
        {
            get { return armadura; }
            set { armadura = value; }
        }
        #endregion

        #region "Costructor"
        public Humanos()
            : base()
        {
            this.armamento = "basuca, rifle";
            this.armadura = "armadura acero";
        }

        public Humanos(string agregar, string nuevaliga, string villano,  string armamento, string armadura)
            : base(agregar, nuevaliga, villano)
        {
            this.armamento = armamento;
            this.armadura = armadura;
        }
        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     
                     "Armas Del Personaje:  " + this.armamento + "\n" +
                     "Armadura Del personaje" + this.armadura;
        }

        public override bool Equals(object obj)
        {
            Humanos h = (Humanos)obj;
            bool result = false;

            if ((this.armamento == h.armamento) &&
                (this.armadura == h.armadura))

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