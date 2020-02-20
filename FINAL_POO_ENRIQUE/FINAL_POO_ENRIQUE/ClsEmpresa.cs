using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_POO_ENRIQUE
{
    class ClsEmpresa
    {
       
        public string Profesion { get; set; }

        public List<ClsEmpleado> _Empleado = new List<ClsEmpleado>();

        public List<ClsEmpleado> Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }

        public List<ClsCliente> _Cliente = new List<ClsCliente>();

        public List<ClsCliente> Cliente
        {
            get { return _Cliente ; }
            set { _Cliente = value; }
        }

        public event FestejarEventHandler FestejarConformidad;
        
        public delegate void FestejarEventHandler(ClsMisArgumentos e);

        private ClsMisArgumentos Estadistica = new ClsMisArgumentos();
        public void Verificar()
        {
            int nConformidad = 0;
            Random Rnd = new Random();

            nConformidad = Rnd.Next(0, 2);

            if (nConformidad == 1)
            {
                FestejarConformidad(Estadistica);
            }
        }

        public ClsEmpleado ClsEmpleado
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ClsCliente ClsCliente
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
