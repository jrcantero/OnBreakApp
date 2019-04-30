﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ContratoCollection;
using ClienteCollection;

namespace OnBreak
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Contrato> ListaContratos = new List<Contrato>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMainCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Bnt_AdminCliente_Click(object sender, RoutedEventArgs e)
        {
            WPFAdminCliente AdminCliente = new WPFAdminCliente();
            AdminCliente.Show();
        }
    }

    

}
