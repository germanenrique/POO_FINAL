using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_POO_ENRIQUE
{
   public class ClsEmpleado : ClsPersona, iInformacion
    {
        #region Interfaz
        string iInformacion.informacion()
        {
            return "El empleado sera agregado";
        }
        #endregion

        #region Delegado
        public delegate void DelOperar();

        public DelOperar operar;
        #endregion

        #region Propiedades
        public int CodigoEmpleado { get; set; }

        public int Sueldo { get; set; }

        public string Profesion { get; set; }

        #endregion
    }
}
