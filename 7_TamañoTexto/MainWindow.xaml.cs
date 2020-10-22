using System.Windows;
using System.Windows.Controls;

namespace _7_TamañoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tamañoFuente_Checked(object sender, RoutedEventArgs e)
        {
            cambiarTextBlock.FontSize = int.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
