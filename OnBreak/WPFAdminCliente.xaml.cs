using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClienteCollection;
using ContratoCollection;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para WPFAdminCliente.xaml
    /// </summary>
    public partial class WPFAdminCliente : Window
    {
        public List<Cliente> ListaClientes = new List<Cliente>();
        public WPFAdminCliente()
        {
            InitializeComponent();
            CargarCombobox();
        }

        private void CargarCombobox()
        {
            cb_Actividad.ItemsSource = Enum.GetValues(typeof(ClienteCollection._actividadEmpresa));
            cb_TipoEmpresa.ItemsSource = Enum.GetValues(typeof(ClienteCollection._tipoEmpresa));
        }


        private void LimpiarForma()
        {
            txtRut.Text = String.Empty;
            txtRazonSocia.Text = String.Empty;
            txtNombreContacto.Text = String.Empty;
            txtEmailContacto.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            cb_Actividad.SelectedIndex = -1;
            cb_TipoEmpresa.SelectedIndex = -1;
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarForma();
        }

        private void Btn_ListarClientes_Click(object sender, RoutedEventArgs e)
        {
            dg_clientes.ItemsSource = ListaClientes;
            dg_clientes.Items.Refresh();
        }

        private void Btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtRut.Text != String.Empty)
            {
                try
                {
                    Cliente lic = ListaClientes.First(l => l.Rut == txtRut.Text);
                    txtRazonSocia.Text = lic.Razonsocial;
                    txtNombreContacto.Text = lic.Nombre;
                    txtEmailContacto.Text = lic.Email;
                    txtDireccion.Text = lic.Direccion;
                    txtTelefono.Text = lic.Telefono.ToString();
                    cb_Actividad.Text = lic.ActividadEmpresa;
                    cb_TipoEmpresa.Text = lic.TipoEmpresa;

                }
                catch (Exception)
                {

                    MessageBox.Show("RUT no encontrado!", "",MessageBoxButton.OK,MessageBoxImage.Exclamation); 
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar RUT para buscar", "No hay RUT", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
