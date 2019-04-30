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


    }
}
