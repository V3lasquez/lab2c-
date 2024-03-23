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

namespace LAB2
{
    /// <summary>
    /// Lógica de interacción para OperSalidas.xaml
    /// </summary>
    public partial class OperSalidas : Window
    {
        public OperSalidas()
        {
            InitializeComponent();
        }
        private void Guardar_Operaciones(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guardado exitosamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
