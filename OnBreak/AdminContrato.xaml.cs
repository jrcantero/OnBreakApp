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
    /// Lógica de interacción para AdminContrato.xaml
    /// </summary>
    public partial class AdminContrato : Window
    {
        public List<Contrato> ListaContratos = new List<Contrato>();

        public AdminContrato()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtnumContrato.Text != String.Empty)
            {
                try
                {

                }
                catch (Exception)
                {

                    MessageBox.Show("Numero de contrato no encontrado"); ;
                }
            }
            else
            {
                MessageBox.Show("Ingrese Numero de Contrato a buscar");
            }
        }
    }
}
