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
using System.Windows.Media.Animation;

namespace Анимация
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DoubleAnimation WA = new DoubleAnimation();
            //WA.From = 200;
            //WA.To = 100;
            //WA.Duration = TimeSpan.FromSeconds(2);
            //WA.RepeatBehavior = RepeatBehavior.Forever;
            //WA.AutoReverse = true;
            //Reklama.BeginAnimation(WidthProperty, WA);

            //DoubleAnimation HA = new DoubleAnimation();
            //HA.From = 50;
            //HA.To = 40;
            //HA.Duration = TimeSpan.FromSeconds(2);
            //HA.RepeatBehavior = RepeatBehavior.Forever;
            //HA.AutoReverse = true;
            //Reklama.BeginAnimation(HeightProperty, HA);
        }
    }
}
