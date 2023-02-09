using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    internal class Model
    {
        public static string FirstNumber;
        public static string SecondNumber;
        public static List<string> Symbols = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> CharSymbols = new List<string> { "+", "-", "*", "/" };

        public static TextBlock tbSymbol;
        public static TextBox tbxResult;

        public static int ComboSymbol
        {
            set
            {
                tbSymbol.Text = CharSymbols[value];
            }
        }

        public static double ResultGet
        {
            set
            {
                try
                {
                    double first = 0;
                    double second = 0;
                    if (FirstNumber != "")
                    {
                        first = Convert.ToDouble(FirstNumber);
                    }
                    if (SecondNumber != "")
                    {
                        second = Convert.ToDouble(SecondNumber);
                    }
                    switch (value)
                    {
                        case 0:
                            tbxResult.Text = Convert.ToString(first + second);
                            break;
                        case 1:
                            tbxResult.Text = Convert.ToString(first - second);
                            break;
                        case 2:
                            tbxResult.Text = Convert.ToString(first * second);
                            break;
                        case 3:
                            if (second == 0)
                            {
                                tbxResult.Text = "Делить на 0 нельзя";
                            }
                            else
                            {
                                tbxResult.Text = Convert.ToString(first / second);
                            }
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("При вычисление арифметической операции возникла ошибка");
                }
            }

        }
    }
}
