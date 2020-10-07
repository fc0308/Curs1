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

namespace Curs1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeAButton();

        }

        public void MakeAButton()
        {
            
// A fancy brush for the background.
LinearGradientBrush fancyBruch =
new LinearGradientBrush(Colors.DarkGreen, Colors.LightGreen, 45);
            myBtn.Background = fancyBruch;
            myBtn.Foreground = new SolidColorBrush(Colors.Yellow);
        }


    }

}
