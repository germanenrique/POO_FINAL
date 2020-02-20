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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        public List<ClsCliente> listacliente = new List<ClsCliente>();
        public List<ClsCliente> lstResultadoCliente = new List<ClsCliente>();
        public List<ClsEmpleado> lstResultadoEmpleado = new List<ClsEmpleado>();
        public  List<ClsEmpleado> listaempleados = new List<ClsEmpleado>();
        public enum Profesiones : int
        {
            Ingeniero = 1,
            Licenciado = 2,
            Mantenimiento = 3,
            Administrativo = 4,
        }
        int con = 0;
        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            cboProfesionEmpleado.DataSource = Enum.GetValues(typeof(Profesiones));
            int cod = 1;
            txtCODCliente.Text = cod.ToString();
        }
        int cod = 1;
        public void aviso(iInformacion algo)
        {
            MessageBox.Show(algo.informacion());
        }
        int cont = 0;
        public void contador()
        {
            cont = cont + 1;
            label20.Text = cont.ToString();

        }

        public void contador2()
        {
            con = con + 1;
            label18.Text = con.ToString();

        }
        public void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaempleados.Count ==0)
                {
                    MessageBox.Show("Primero debe agregar un empleado");
                    return;
                }
                ClsCliente cliente = new FINAL_POO_ENRIQUE.ClsCliente();
                cliente.nombre = txtNombreCliente.Text;
                cliente.apellido = txtApellidoCliente.Text;
                cliente.DNI = Convert.ToInt32(txtDNICliente.Text);
                cliente.Localidad.NombreCalle = txtLocCalleCliente.Text;
                
                cliente.Localidad.NumeroCalle = Convert.ToInt32(txtLocNumeroCliente.Text);
                cliente.CodigoCliente = Convert.ToInt32(txtCODCliente.Text);
                if(radioButton3.Checked)
                {
                    cliente.Venta = Convert.ToInt32(txtVENTACliente.Text);
                    cliente.CalculoVenta();
                }
                else
                {
                    cliente.Venta = Convert.ToInt32(txtVENTACliente.Text);
                }
                ClsEmpresa empresa = new ClsEmpresa();
                empresa._Cliente.Add(cliente);
                listacliente.Add(cliente);
                datacliente();
                limpiarcliente();
                cod++;
                txtCODCliente.Text = cod.ToString();
                aviso(cliente);
                cliente.operar = contador;
                cliente.operar.Invoke();
                listBox1.Items.Add(cliente);
                

            }
            catch
            {
                MessageBox.Show("Verificar los datos ingresados");
            }
        }

        public void limpiarcliente()
        {
            txtNombreCliente.Text = null;
            txtApellidoCliente.Text = null;
            txtDNICliente.Text = null;
            txtLocCalleCliente.Text = null;
            txtLocNumeroCliente.Text = null;
            txtVENTACliente.Text = null;
            txtCODCliente.Text = null;
            radioButton3.Checked = false;

        }
        public void datacliente()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listacliente;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1Cliente.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1Cliente.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmpleado empleado = new FINAL_POO_ENRIQUE.ClsEmpleado();
                empleado.nombre = txtNombreEmpleado.Text;
                empleado.apellido = txtApellidoEmpleado.Text;
                empleado.DNI = Convert.ToInt32(txtDNIEmpleado.Text);
                empleado.Localidad.NombreCalle = txtLocCalleEmpleado.Text;
                empleado.Localidad.NumeroCalle = Convert.ToInt32(txtLocNumeroEmpleado.Text);
                empleado.CodigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text);
                empleado.Sueldo = Convert.ToInt32(txtSueldoEmpleado.Text);
                empleado.Profesion = cboProfesionEmpleado.Text;
                listaempleados.Add(empleado);
                dataEmpleado();
                limpiarEmpleado();
                ClsEmpresa empresa = new ClsEmpresa();
                empresa._Empleado.Add(empleado);
                aviso(empleado);
                empleado.operar = contador2;
                empleado.operar.Invoke();
            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados");
            }
        }

        public void dataEmpleado()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaempleados;
        }
        
        public void limpiarEmpleado()
        {
            txtNombreEmpleado.Text = null;
            txtApellidoEmpleado.Text = null;
            txtDNIEmpleado.Text = null;
            txtLocCalleEmpleado.Text = null;
            txtLocNumeroEmpleado.Text = null;
            txtCodigoEmpleado.Text = null;
            txtSueldoEmpleado.Text = null;
        }

        private void tag_Click(object sender, EventArgs e)
        {

            List<ClsCliente> lstResultadoClientes = new List<ClsCliente>();

            foreach (ClsCliente item in listacliente)
            {
                
                if (item.Venta > 300 )
                {
                    
                    ClsCliente oCliente= new ClsCliente();
                    oCliente = item;
                    lstResultadoClientes.Add(oCliente);
                    
                    
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstResultadoClientes;
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCliente Buscador = new ClsCliente();
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            else
            {
                Buscador.DNI = Convert.ToInt32(textBox1.Text);
            }
           
            
            foreach (ClsCliente item in listacliente)
            {
                if (item.DNI == Buscador.DNI)
                {
                    
                    ClsCliente Cliente = new ClsCliente();
                    Cliente = item;

                    lstResultadoCliente.Add(Cliente);

                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstResultadoCliente;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<ClsEmpleado> lstResultadoEmpleados = new List<ClsEmpleado>();

            foreach (ClsEmpleado item in listaempleados)
            {

                if (item.Profesion == "Mantenimiento")
                {

                    ClsEmpleado oEmpleado = new ClsEmpleado();
                    oEmpleado = item;
                    lstResultadoEmpleados.Add(oEmpleado);


                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lstResultadoEmpleados;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsEmpleado Buscador = new ClsEmpleado();
            Buscador.DNI = Convert.ToInt32(textBox2.Text);

            foreach (ClsEmpleado item in listaempleados)
            {
                if (item.DNI == Buscador.DNI)
                {

                    ClsEmpleado Empleado = new ClsEmpleado();
                    Empleado = item;

                    lstResultadoEmpleado.Add(Empleado);

                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lstResultadoEmpleado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = (ClsCliente)listBox1.SelectedItem;
            ClsCliente clon = (ClsCliente)cliente.Clone();
            listBox2.Items.Add(clon);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClsEmpresa jefe = new ClsEmpresa();
            jefe.FestejarConformidad += Conformidad_Festejar;
            limpiar();
            jefe.Verificar();
        }

        private void Conformidad_Festejar(ClsMisArgumentos e)
        {
            label22.Text = "Si";
            
        }

        public void limpiar()
        {
            label22.Text = "-";
        }
    }
}
