using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace PixelArt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        public void Cuadricula_Pequena(int numeroCuadros) { 

            pixeles.Children.Clear();

            for (int i = 0; i < numeroCuadros; i++)
            {
                for (int j = 0; j < numeroCuadros; j++) 
                {
                    Border bd = new Border();
                    bd.BorderBrush = Brushes.Gray;
                    bd.BorderThickness = new Thickness(1);

                    pixeles.Children.Add(bd);
                }
 
            }

           
        }

        private void Numero_Cuadriculas(object sender, RoutedEventArgs e)
        {
             
            int cuadros = Convert.ToInt16((sender as Button).Tag);
            Cuadricula_Pequena(cuadros);

        }

        private Color RadioButton_Cambia_Color_Cheked(object sender, RoutedEventArgs e)
        {
            var c = new Color();

            if ((sender as RadioButton).Content.Equals("Personalizado"))
            {
                if (textBoxColor.Text == null)
                    c = (Color)ColorConverter.ConvertFromString(textBoxColor.Text);
                else 
                { 
                    c = (Color)ColorConverter.ConvertFromString(textBoxColor.Text);
                }
            }
            else {
                string aux = Convert.ToString((sender as Button).Tag);
                c = (Color)ColorConverter.ConvertFromString(aux);
            }

            return c;
        }
    }
}
