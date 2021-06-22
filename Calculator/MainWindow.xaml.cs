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
    /// 

    public partial class MainWindow : Window
    {

        Function C;
        public const double PI = Math.PI;
        public const double E = 2.7182818284;


        private void CorrectNumber()
        {
            //Если есть знак "бесконечность" - не даёт писать цифры после него
            if (lblNumber.Text.IndexOf("∞") != -1)
                lblNumber.Text = lblNumber.Text.Substring(0, lblNumber.Text.Length - 1);

            //Округление
            if (lblNumber.Text[0] == '0' && (lblNumber.Text.IndexOf(",") != 1))
                lblNumber.Text = lblNumber.Text.Remove(0, 1);

            //Округление для отрицательного числа
            if (lblNumber.Text[0] == '-')
                if (lblNumber.Text[1] == '0' && (lblNumber.Text.IndexOf(",") != 2))
                    lblNumber.Text = lblNumber.Text.Remove(1, 1);
        }

        
          private bool CanPress()
        {
            if (!btnMultiply.IsEnabled)
                return false;

            if (!btnDivide.IsEnabled)
                return false;

            if (!btnPlus.IsEnabled)
                return false;

            if (!btnMinus.IsEnabled)
                return false;

            if (!btnSin.IsEnabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            btnMultiply.IsEnabled = true;
            btnDivide.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnMinus.IsEnabled = true;
        }

        public MainWindow()
        {
            InitializeComponent();

            C = new Function();
            lblNumber.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text = "0";

            C.Clear_A();
            FreeButtons();
        }

        private void btnBracketLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBracketRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lblNumber.Text));

                btnDivide.IsEnabled = false;

                lblNumber.Text = "0";
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "7";

            CorrectNumber();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "8";

            CorrectNumber();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "9";

            CorrectNumber();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lblNumber.Text));

                btnMultiply.IsEnabled = false;

                lblNumber.Text = "0";
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "4";

            CorrectNumber();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "5";

            CorrectNumber();
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "6";

            CorrectNumber();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lblNumber.Text));

                btnMinus.IsEnabled = false;

                lblNumber.Text = "0";
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "1";

            CorrectNumber();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "2";

            CorrectNumber();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "3";

            CorrectNumber();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lblNumber.Text));

                btnPlus.IsEnabled = false;

                lblNumber.Text = "0";
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += "0";

            CorrectNumber();
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if ((lblNumber.Text.IndexOf(",") == -1) && (lblNumber.Text.IndexOf("∞") == -1))
                lblNumber.Text += ",";
        }

        private void btnEqually_Click(object sender, RoutedEventArgs e)
        {

            if (!btnMultiply.IsEnabled)
                lblNumber.Text = C.Multiplication(Convert.ToDouble(lblNumber.Text)).ToString();

            if (!btnDivide.IsEnabled)
                lblNumber.Text = C.Division(Convert.ToDouble(lblNumber.Text)).ToString();

            if (!btnPlus.IsEnabled)
                lblNumber.Text = C.Sum(Convert.ToDouble(lblNumber.Text)).ToString();

            if (!btnMinus.IsEnabled)
                lblNumber.Text = C.Subtraction(Convert.ToDouble(lblNumber.Text)).ToString();


            C.Clear_A();
            FreeButtons();
        }

        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += E;

            CorrectNumber();
        }

        private void btnPI_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Text += PI;

            CorrectNumber();
        }


        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(lblNumber.Text));

                btnPlus.IsEnabled = false;

                lblNumber.Text = "0";
            }
        }

        private void btnDeg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
