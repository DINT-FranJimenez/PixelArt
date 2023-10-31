using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        private string backgroundBorder = "Black" ;
        private int cuadros = 5;

        public MainWindow()
        {
            InitializeComponent();
            Cuadricula_Pequena(cuadros);

        }

        public void Cuadricula_Pequena(int numeroCuadros) { 

            pixeles.Children.Clear();

            for (int i = 0; i < numeroCuadros; i++)
            {
                for (int j = 0; j < numeroCuadros; j++) 
                {
                    Border bd = new Border();
                    bd.BorderThickness = new Thickness(1);
                    bd.BorderBrush = Brushes.Gray;
                    Grid g = new Grid();
                    g.Style = (Style)FindResource("BackGroundColor");
                    g.Background = Brushes.White;
                    bd.Child = g;
   
                    pixeles.Children.Add(bd);
                }
 
            }

           
        }

        private void Numero_Cuadriculas(object sender, RoutedEventArgs e)
        {
             
            cuadros = Convert.ToInt16((sender as Button).Tag);
            Cuadricula_Pequena(cuadros);

        }

        private void Click_RadioButtonCambiaColor_Chek(object sender, RoutedEventArgs e)
        {
            

             if ((sender as RadioButton).Content.Equals("Personalizado"))
             {
                if (textBoxColor.Text == null)
                    backgroundBorder = "White";
                else
                {
                    backgroundBorder = textBoxColor.Text;
                }
             }
             else
             { 
                backgroundBorder =(string)(sender as RadioButton).Tag;
             }

            
        }

        private void CambiaColor_MouseEnter(object sender, MouseEventArgs e) {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                SolidColorBrush solidColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundBorder));

                (sender as Grid).Background = solidColorBrush;
            }
         

        }


        private void CambiaColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                SolidColorBrush solidColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundBorder));

                (sender as Grid).Background = solidColorBrush;
            }
        }

        private void RellenaTodoUnColor_Click(object sender, RoutedEventArgs e)
        {


            SolidColorBrush solidColorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundBorder));

            pixeles.Children.Clear();

            for (int i = 0; i < cuadros; i++)
            {
                for (int j = 0; j < cuadros; j++)
                {
                    Border bd = new Border();
                    bd.BorderThickness = new Thickness(1);
                    bd.BorderBrush = Brushes.Gray;
                    Grid g = new Grid();
                    g.Style = (Style)FindResource("BackGroundColor");
                    g.Background = solidColorBrush;
                    bd.Child = g;



                    pixeles.Children.Add(bd);

                    
                }

            }
        }

       
    }
}
