using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public partial class Form1 : Form
    {
        private List<Vehiculo> vehiculos;
        
        public Form1()
        {
            InitializeComponent();
            vehiculos = new List<Vehiculo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = null;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString();

            if (tipoVehiculo == "Auto")
            {
                vehiculo = new Auto (marca, modelo);
                dataGridViewVehiculos.Rows.Add ("Auto",marca,modelo ,"","");
            }
            else if (tipoVehiculo == "Camion")
            {
                int capacidadCarga = int.Parse(txtCapacidadCarga.Text);
                vehiculo = new Camion(marca, modelo, capacidadCarga);
                dataGridViewVehiculos.Rows.Add("Camion",marca, modelo,"",capacidadCarga.ToString());
            }
            else if (tipoVehiculo == "Motocicleta")
            {
                vehiculo = new Motocicleta (marca, modelo);
                dataGridViewVehiculos.Rows.Add("Motocicleta",marca,modelo,"","");
            }
            else if (tipoVehiculo == "Auto Electrico")
            {
                int capacidadBateria = int.Parse(txtCapacidadBateria.Text);
                vehiculo = new Auto_Electrico(marca, modelo, capacidadBateria);
                dataGridViewVehiculos.Rows.Add("Vehiculo Electrico",marca,modelo, capacidadBateria.ToString(),"");
            }
            vehiculos.Add(vehiculo);
            
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString();

            if (tipoVehiculo == "Auto")
            {
                lblCapacidadBateria.Visible = false;
                txtCapacidadBateria.Visible = false;
                lblCapacidadCarga.Visible = false;
                txtCapacidadCarga.Visible = false;
                btnCargaBateria.Visible = false;
            }
            else if (tipoVehiculo == "Camion")
            {
                lblCapacidadCarga.Visible = true;
                txtCapacidadCarga.Visible = true;
                lblCapacidadBateria.Visible = false;
                txtCapacidadBateria.Visible = false;
                btnCargaBateria.Visible = false;
            }
            else if (tipoVehiculo == "Motocicleta")
            {
                lblCapacidadBateria.Visible = false;
                txtCapacidadBateria.Visible = false;
                lblCapacidadCarga.Visible = false;
                txtCapacidadCarga.Visible = false;
                btnCargaBateria.Visible = false;
            }
            else if (tipoVehiculo == "Auto Electrico")
            {
                lblCapacidadCarga.Visible = false;
                txtCapacidadCarga.Visible = false;
                lblCapacidadBateria.Visible = true;
                txtCapacidadBateria.Visible = true;
                btnCargaBateria.Visible = true;
            }
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                int index = dataGridViewVehiculos.SelectedRows[0].Index;
                Vehiculo vehiculoSeleccionado = vehiculos[index];
                vehiculoSeleccionado.Arrancar();
            }
        }

        private void btnMoverse_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                int index = dataGridViewVehiculos.SelectedRows[0].Index;
                Vehiculo vehiculoSeleccionado = vehiculos[index];
                vehiculoSeleccionado.Moverse();
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                int index = dataGridViewVehiculos.SelectedRows[0].Index;
                Vehiculo vehicluloSeleccionado = vehiculos[index];
                vehicluloSeleccionado.Detener();
            }
        }

        private void btnCargaBateria_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                int index = dataGridViewVehiculos.SelectedRows[0].Index;
                Vehiculo vehiculoSeleccionado = vehiculos[index];

                if (vehiculoSeleccionado is IElectrico vehiculoElectrico)
                {
                    vehiculoElectrico.CargarBateria();
                }
                else
                {
                    MessageBox.Show("Este vehículo no es eléctrico.");
                }
            }

        }
    }
    
}
