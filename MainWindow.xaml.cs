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

namespace Einführung_Canvas
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            x = Canvas.GetLeft(box1);
            y = Canvas.GetBottom(box1);
        }
        private double x;
        private double y;
        
        private void Links_Click(object sender, RoutedEventArgs e)
        {

            //Sie können in einem Canvas die Eigenschaft Left und Bottom mit:
            //double x =Canvas.GetLeft(box1);
            //double y =Canvas.GetBottom(box1); //lesen und mit:
            //double wert = 10;
            //Canvas.SetBottom(box1, wert);
            //Canvas.SetTop(box1, wert);//werden diese Eigenschaften auf den neuen Wert gesetzt
            
            if (x >= 10)
            {
                x -= 10;
                Canvas.SetLeft(box1, x);
            }
        }

        private void Unten_Click(object sender, RoutedEventArgs e)
        {
            
            if (y >= 10)
            {
                y -= 10;
                Canvas.SetBottom(box1, y);
            }
        }

        private void Hoch_Click(object sender, RoutedEventArgs e)
        {
            // das Rechteck soll um 10 pixel nach oben verschoben werden.
            // y muss 10 größer werden.
            
            if (y <= 340)
            {
                y += 10;
                Canvas.SetBottom(box1, y);
            }

        }

        private void Rechts_Click(object sender, RoutedEventArgs e)
        {
            
            if (x <= 700)
            {
                x += 10;
                Canvas.SetLeft(box1, x);
            }
        }
    }
}
