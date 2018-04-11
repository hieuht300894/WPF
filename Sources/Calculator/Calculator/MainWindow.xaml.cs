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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Format();
        }

        void Format()
        {
            Background = Brushes.Black;
            ResizeMode = ResizeMode.CanMinimize;

            btn0.Background = Brushes.Transparent;
            btn1.Background = Brushes.Transparent;
            btn1Divx.Background = Brushes.Transparent;
            btn2.Background = Brushes.Transparent;
            btn3.Background = Brushes.Transparent;
            btn4.Background = Brushes.Transparent;
            btn5.Background = Brushes.Transparent;
            btn6.Background = Brushes.Transparent;
            btn7.Background = Brushes.Transparent;
            btn8.Background = Brushes.Transparent;
            btn9.Background = Brushes.Transparent;
            btnC.Background = Brushes.Transparent;
            btnCE.Background = Brushes.Transparent;
            btnDel.Background = Brushes.Transparent;
            btnDiv.Background = Brushes.Transparent;
            btnDot.Background = Brushes.Transparent;
            btnEqual.Background = Brushes.Transparent;
            btnHistory.Background = Brushes.Transparent;
            btnMC.Background = Brushes.Transparent;
            btnMCB.Background = Brushes.Transparent;
            btnMenu.Background = Brushes.Transparent;
            btnMPlus.Background = Brushes.Transparent;
            btnMR.Background = Brushes.Transparent;
            btnMS.Background = Brushes.Transparent;
            btnMSub.Background = Brushes.Transparent;
            btnMul.Background = Brushes.Transparent;
            btnPercent.Background = Brushes.Transparent;
            btnPlus.Background = Brushes.Transparent;
            btnPlusMinus.Background = Brushes.Transparent;
            btnSQRT.Background = Brushes.Transparent;
            btnSub.Background = Brushes.Transparent;
            btnxPOW2.Background = Brushes.Transparent;
            lbResult.Background = Brushes.Transparent;
            lbTitle.Background = Brushes.Transparent;

            btn0.Foreground = Brushes.White;
            btn1.Foreground = Brushes.White;
            btn1Divx.Foreground = Brushes.White;
            btn2.Foreground = Brushes.White;
            btn3.Foreground = Brushes.White;
            btn4.Foreground = Brushes.White;
            btn5.Foreground = Brushes.White;
            btn6.Foreground = Brushes.White;
            btn7.Foreground = Brushes.White;
            btn8.Foreground = Brushes.White;
            btn9.Foreground = Brushes.White;
            btnC.Foreground = Brushes.White;
            btnCE.Foreground = Brushes.White;
            btnDel.Foreground = Brushes.White;
            btnDiv.Foreground = Brushes.White;
            btnDot.Foreground = Brushes.White;
            btnEqual.Foreground = Brushes.White;
            btnHistory.Foreground = Brushes.White;
            btnMC.Foreground = Brushes.White;
            btnMCB.Foreground = Brushes.White;
            btnMenu.Foreground = Brushes.White;
            btnMPlus.Foreground = Brushes.White;
            btnMR.Foreground = Brushes.White;
            btnMS.Foreground = Brushes.White;
            btnMSub.Foreground = Brushes.White;
            btnMul.Foreground = Brushes.White;
            btnPercent.Foreground = Brushes.White;
            btnPlus.Foreground = Brushes.White;
            btnPlusMinus.Foreground = Brushes.White;
            btnSQRT.Foreground = Brushes.White;
            btnSub.Foreground = Brushes.White;
            btnxPOW2.Foreground = Brushes.White;
            lbResult.Foreground = Brushes.White;
            lbTitle.Foreground = Brushes.White;

            //btn0.Content = "0";
            //btn1.Content = "1";
            //btn1Divx.Content = "1/x";
            //btn2.Content = "2";
            //btn3.Content = "3";
            //btn4.Content = "4";
            //btn5.Content = "5";
            //btn6.Content = "6";
            //btn7.Content = "7";
            //btn8.Content = "8";
            //btn9.Content = "9";
            //btnC.Content = "C";
            //btnCE.Content = "CE";
            //btnDel.Content = "Del";
            //btnDiv.Content = "/";
            //btnDot.Content = ".";
            //btnEqual.Content = "=";
            //btnHistory.Content = "";
            //btnMC.Content = "MC";
            //btnMCB.Content = "";
            //btnMenu.Content = "";
            //btnMPlus.Content = "M+";
            //btnMR.Content = "MR";
            //btnMS.Content = "MS";
            //btnMSub.Content = "M-";
            //btnMul.Content = "*";
            //btnPercent.Content = "%";
            //btnPlus.Content = "+";
            //btnPlusMinus.Content = "±";
            //btnSQRT.Content = "";
            //btnSub.Content = "-";
            //btnxPOW2.Content = "";
            //lbResult.Content = "0";
            //lbTitle.Content = "";
        }
    }
}
