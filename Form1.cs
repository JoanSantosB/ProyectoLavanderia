using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLavanderia
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Servicio> servicios;
        private Dictionary<string, Estudiante> estudiantes;
        private Dictionary<string, Maquina> maquinas;

        private double totalVentasDia;
        private double totalDescunetosDia;
        public Form1()
        {
            InitializeComponent();
            servicios = new Dictionary<int, Servicio>();
            estudiantes = new Dictionary<string, Estudiante>();
            maquinas = new Dictionary<string, Maquina>();

            maquinas.Add("L0010", new Maquina("L0010", "Lavadora", "Disponible", 0));
            maquinas.Add("L0020", new Maquina("L0020", "Lavadora", "Disponible", 0));
            maquinas.Add("S0015", new Maquina("S0015", "Secadora", "Disponible", 0));
            maquinas.Add("S0025", new Maquina("S0025", "Secadora", "Disponible", 0));
            dgvMaquinas.DataSource = maquinas.Values.ToList();
            cmbTipoRopa.Items.Add("Ropa Blanca");
            cmbTipoRopa.Items.Add("Ropa de Color");
            cmbTipoRopa.Items.Add("Ropa Delicada");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            int numeroOrden;
            if (int.TryParse(textNumeroOrden.Text, out numeroOrden))
            {
                if (servicios.ContainsKey(numeroOrden))
                {
                    MessageBox.Show("Número de orden ya existe.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Número de orden no válido, debe ser un número entero.");
                return;
            }
            string nombre = textNombre.Text;
            string telefono = textTelefono.Text;
            string carnet = textCarnet.Text;
            if (nombre.Length >= 3)
            {
                if (telefono.Length == 8)
                {
                    if (cmbTipoRopa.Text == "")
                    {
                        MessageBox.Show("Error---Debe seleccionar un tipo de ropa.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error---Teléfono incorrecto.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error---Nombre incorrecto.");
                return;
            }
            if (chkEstudiante.Checked == true)
            {
                if (carnet.Length == 10)
                {
                    if (estudiantes.ContainsKey(carnet))
                    {
                        MessageBox.Show("Carnet ya registrado, se usará la información existente.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error---Carnet incorrecto.");
                    return;
                }
            }
            int cantidad = (int)numPrendas.Value;
            Servicio servicio = new Servicio(numeroOrden, cantidad, cmbTipoRopa.Text, chkPlanchado.Checked, chkDetergentePremium.Checked);
            servicios.Add(numeroOrden, servicio);
            double total = servicio.CalcularTotal();
            double descuento = 0;
            if (chkEstudiante.Checked == true)
            {
                Estudiante estudiante = new Estudiante(nombre, telefono, carnet);
                estudiantes.Add(carnet, estudiante);
                descuento=servicio.CalcularTotal() * 0.15;
                total = servicio.TotalEstudianteDescuento(true);
            }
            totalVentasDia+= total;
            totalDescunetosDia += descuento;
            textRecibo.Text = "\t==Recibo de Lavandería==" + Environment.NewLine +
            "\nNúmero de Orden: " + numeroOrden + Environment.NewLine +
            "\nNombre: " + nombre + Environment.NewLine +
            "\nTeléfono: " + telefono + Environment.NewLine +
            "\n¿Es estudiante?: " + (chkEstudiante.Checked ? "Sí" : "No") + Environment.NewLine +
            "\nCarnet: " + carnet + Environment.NewLine +
            "\nTipo de Ropa: " + cmbTipoRopa.Text + Environment.NewLine +
            "\nCantidad de prendas: " + cantidad + Environment.NewLine +
            "\nPlanchado: " + (chkPlanchado.Checked ? "Sí" : "No") + Environment.NewLine +
            "\nDetergente Premium: " + (chkDetergentePremium.Checked ? "Sí" : "No") + Environment.NewLine +
            "\nTotal a pagar: Q" + total.ToString("F2") + Environment.NewLine +
            "=============================";
            MessageBox.Show("Se ha generado el recibo correctamente.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNumeroOrden.Clear();
            textNombre.Clear();
            textTelefono.Clear();
            textCarnet.Clear();
            chkEstudiante.Checked = false;
            chkPlanchado.Checked = false;
            chkDetergentePremium.Checked = false;
            numPrendas.Value = 1;
            cmbTipoRopa.SelectedIndex = 0;
            textRecibo.Clear();
            textNumeroOrden.Focus();
        }

        private void btnIniciarMaquina_Click(object sender, EventArgs e)
        {
            if(dgvMaquinas.CurrentRow != null)
            {
                Maquina maquina=(Maquina)dgvMaquinas.CurrentRow.DataBoundItem;
                maquina.InformacionMaquina();
                dgvMaquinas.Refresh();
            }
        }
    }
}
