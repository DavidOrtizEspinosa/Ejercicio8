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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio8
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


        public static bool isNumeric(String cadena)
        {

            bool resultado;

            try
            {
                int.Parse(cadena);
                resultado = true;
            }
            catch (FormatException)
            {
                resultado = false;
            }
            return resultado;
        }


            private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch((sender as TextBox).Tag.ToString())
            {
                case "Nombre":
                    if (e.Key==Key.F1)
                    {
                        if (nombreTextBlock.IsVisible)
                        {
                            nombreTextBlock.Visibility = Visibility.Hidden;
                        }
                        else
                        {
                            nombreTextBlock.Visibility = Visibility.Visible;
                        }
                    }
                    break;
                case "Apellido":
                    if (e.Key == Key.F1)
                    {
                        if (apellidoTextBlock.IsVisible)
                        {
                            apellidoTextBlock.Visibility = Visibility.Hidden;
                        }
                        else
                        {
                            apellidoTextBlock.Visibility = Visibility.Visible;
                        }
                    }
                    break;
                case "Edad":
                    if (e.Key == Key.F2)
                    {
                        if (!isNumeric(edadTextBox.Text))
                        {
                            edadTextBlock.Visibility = Visibility.Visible;
                        }
                        else { edadTextBlock.Visibility = Visibility.Hidden; }
                    }
                    break;
            }
            
        }
    }
}
