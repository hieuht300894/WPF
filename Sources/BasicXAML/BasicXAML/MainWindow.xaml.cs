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

namespace BasicXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WrapPanel pnMain = new WrapPanel();

            TextBlock txtMain = new TextBlock();
            txtMain.Foreground = Brushes.Blue;
            txtMain.Text = "Multi";
            pnMain.Children.Add(txtMain);

            txtMain = new TextBlock();
            txtMain.Foreground = Brushes.Red;
            txtMain.Text = "Color";
            pnMain.Children.Add(txtMain);

            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;
            btn.Content = "Button";
            pnMain.Children.Add(btn);

            grMain.Children.Add(pnMain);
        }
    }
}
