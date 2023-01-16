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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbxResult = ResultBox;
            Model.tbSymbol = SymbolBox;

            Combo.ItemsSource = Model.Symbols;
            Combo.SelectedIndex = 0;

        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.ComboSymbol = Combo.SelectedIndex;
        }

        private void CountBtn_Click(object sender, RoutedEventArgs e)
        {
            Model.First = Convert.ToDouble(FirstBox.Text);
            Model.Second = Convert.ToDouble(SecondBox.Text);

            if(Model.First != 0 || Model.Second != 0)
            {
                if(Combo.SelectedIndex == 1)
                {
                    
                }
                if (Combo.SelectedIndex == 2)
                {

                }
            }
        }
    }
}
