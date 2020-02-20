using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_POO_ENRIQUE
{
  public class ClsCliente : ClsPersona, iInformacion,ICloneable
    {
        public object Clone()
        {
            ClsCliente c = (ClsCliente)this.MemberwiseClone();
            return c;
        }
        #region Interfaz
        string iInformacion.informacion()
        {
            return "El cliente sera agregado";
        }
        #endregion

        #region Delegado
        public delegate void DelOperar();

        public DelOperar operar;
        #endregion

        #region Propiedades
        public int CodigoCliente { get; set; }

        public double Venta { get; set; }

        #endregion

        #region Operacion
        public void CalculoVenta()
        {
            Venta = Venta - (Venta * 0.10);
        }
        #endregion

        public override string ToString()
        {
            return nombre;
        }
    }
}
