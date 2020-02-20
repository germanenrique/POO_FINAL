using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_POO_ENRIQUE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1) Para agregar un cliente primero debe agregar un empleado");
            MessageBox.Show(" 2) Si el cliente es socio se le hara un descuento del 10%");
            FormEmpresa empresa = new FINAL_POO_ENRIQUE.FormEmpresa();
            empresa.Show();
        }
    }
}
