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

namespace WpfApp14
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand newroutedCommand1 = new RoutedCommand();
        public static RoutedCommand newroutedCommand2 = new RoutedCommand();
        public MainWindow()
        {
            InitializeComponent();
            newroutedCommand1.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(newroutedCommand1, ShortKey_Click1));

            newroutedCommand2.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(newroutedCommand2, ShortKey_Click2));
        }
        // raccourcis de type Ctrl+*
        private void ShortKey_Click1(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Ctrl+R pressed");
        }
        private void ShortKey_Click2(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Ctrl+S pressed");
        }
        private void Windows_Keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                System.Diagnostics.Process.Start("file:///C:/Users/Azur%20Computer/Desktop/Help/GuideD'util.html");

            }
            if (e.Key == Key.Escape)
            {
                MessageBox.Show("Escape pressed ");
            }
            if (e.Key == Key.F2)
            {
                MessageBox.Show("F2 pressed ");
            }
            //...
            //...
            //...
            //add shortcuts as many as needed 
        }
    }
}
