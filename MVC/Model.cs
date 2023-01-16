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
        public double FirstNumber;
        public double SecondNumber;
        public static List<string> Symbols = new List<string> {"Сложение", "Вычитание", "Умножение", "Деление"};

        public static TextBlock tbSymbol;
        public static TextBox tbxResult;
    }
}
