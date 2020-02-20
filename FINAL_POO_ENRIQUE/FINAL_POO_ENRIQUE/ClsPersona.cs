using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_POO_ENRIQUE
{
   public abstract class ClsPersona
    {
        #region Propiedades
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int DNI { get; set; }

        public ClsLocalidad Localidad = new ClsLocalidad();
        #endregion

        
    }
}
