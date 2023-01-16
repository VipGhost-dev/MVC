using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVC
{
    internal class Model
    {
        public static double FirstNumber;
        public static double SecondNumber;
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

        public static double First
        {
            get
            {
                return FirstNumber;
            }
            set
            {
                FirstNumber = value;
            }
        }

        public static double Second
        {
            get
            { 
                return SecondNumber; 
            }
            set
            {
                SecondNumber = value;
            }
        }
    }
}
