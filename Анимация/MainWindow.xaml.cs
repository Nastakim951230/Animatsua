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
            DoubleAnimation WA = new DoubleAnimation();
            WA.From = 200;
            WA.To = 100;
            WA.Duration = TimeSpan.FromSeconds(2);
            WA.RepeatBehavior = RepeatBehavior.Forever;
            WA.AutoReverse = true;
            Reklama.BeginAnimation(WidthProperty, WA);

            ThicknessAnimation MA = new ThicknessAnimation(); 
            MA.From = new Thickness(20, 20, 20, 20);
            MA.To = new Thickness(0, 0, 0, 0);
            MA.Duration = TimeSpan.FromSeconds(2);
            MA.RepeatBehavior = RepeatBehavior.Forever;
            MA.AutoReverse = true;
            Reklama.BeginAnimation(MarginProperty, MA);


            DoubleAnimation HA = new DoubleAnimation();
            HA.From = 30;
            HA.To = 40;
            HA.Duration = TimeSpan.FromSeconds(2);
            HA.RepeatBehavior = RepeatBehavior.Forever;
            HA.AutoReverse = true;
            Reklama.BeginAnimation(HeightProperty, HA);

            ColorAnimation colorbtn1 = new ColorAnimation();
            ColorConverter colorConverterbtn1 = new ColorConverter();
            Color ColorStartbtn1 = (Color)colorConverterbtn1.ConvertFrom("#ff6274");
            Reklama.BorderBrush = new SolidColorBrush(ColorStartbtn1);
            colorbtn1.From = ColorStartbtn1;
            colorbtn1.To = (Color)colorConverterbtn1.ConvertFrom("#743eff");
            colorbtn1.Duration = TimeSpan.FromSeconds(2);
            colorbtn1.RepeatBehavior = RepeatBehavior.Forever;
            colorbtn1.AutoReverse = true;
            Reklama.BorderBrush.BeginAnimation(SolidColorBrush.ColorProperty, colorbtn1);

            ColorAnimation colorbtn = new ColorAnimation();
            ColorConverter colorConverterbtn = new ColorConverter();
            Color ColorStartbtn = (Color)colorConverterbtn.ConvertFrom("#fdd4d8");
            Reklama.Background = new SolidColorBrush(ColorStartbtn);
            colorbtn.From = ColorStartbtn;
            colorbtn.To = (Color)colorConverterbtn.ConvertFrom("#c2cbfc");
            colorbtn.Duration = TimeSpan.FromSeconds(2);
            colorbtn.RepeatBehavior = RepeatBehavior.Forever;
            colorbtn.AutoReverse = true;
            Reklama.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorbtn);


            ColorAnimation color =new ColorAnimation();
            ColorConverter colorConverter=new ColorConverter();
            Color ColorStart = (Color)colorConverter.ConvertFrom("#ff0000");
            aktsia.Foreground = new SolidColorBrush(ColorStart);
            color.From=ColorStart;
            color.To=(Color)colorConverter.ConvertFrom("#a80ced");
            color.Duration = TimeSpan.FromSeconds(2);
            color.RepeatBehavior = RepeatBehavior.Forever;
            color.AutoReverse = true;
            aktsia.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, color);

            DoubleAnimation size = new DoubleAnimation();
            size.From = 18;
            size.To = 24;
            size.Duration = TimeSpan.FromSeconds(2);
            size.RepeatBehavior = RepeatBehavior.Forever;
            size.AutoReverse = true;
            aktsia.BeginAnimation(FontSizeProperty, size);
        }

        private void Reklama_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation WA = new DoubleAnimation();
            WA.From = 250;
            WA.To = 270;
            WA.Duration = TimeSpan.FromSeconds(2);
          
            img.BeginAnimation(WidthProperty, WA);

            DoubleAnimation HA = new DoubleAnimation();
            HA.From = 200;
            HA.To = 220;
            HA.Duration = TimeSpan.FromSeconds(2);
            img.BeginAnimation(HeightProperty, HA);

        }
    }
}
