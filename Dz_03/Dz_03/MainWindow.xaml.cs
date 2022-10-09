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

namespace Dz_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String text = tbInput.GetLineText(0);
            tbInput.Text = "";
            String temp = "";
            bool isReversed = false;
            for (int i = 0; i < text.Length; i++)
            {
                
                if (Char.IsLetter(text[i]))// || Char.IsDigit(text[i]))
                {

                    temp = text[i] + temp;
                }
                else
                {
                    
                    tbInput.Text += temp + text[i];
                    temp = "";
                    isReversed = true;

                }
            }
            if (!isReversed) tbInput.Text += temp;


        }
    }
}
