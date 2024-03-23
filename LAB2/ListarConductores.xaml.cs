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
using System.Windows.Shapes;

namespace LAB2
{
    /// <summary>
    /// Lógica de interacción para ListarConductores.xaml
    /// </summary>
    public partial class ListarConductores : Window
    {
        public ListarConductores()
        {
            InitializeComponent();
        }
        public class DatosConductor
        {
            public string NombreConductor { get; set; }
            public string Licencia { get; set; }
            public string Transporte { get; set; }
        }
    }
}
