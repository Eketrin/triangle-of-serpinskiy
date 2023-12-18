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

namespace triangle_of_serpinskiy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Point(Canvas canvas, Point point)
        {
            Shape elips = new Ellipse()
            {
                Height = 1,
                Width = 1,
                Stroke = Brushes.Tomato,
                StrokeThickness = 1
                
            };
            canvas.Children.Add(elips);
        }



    }
}
