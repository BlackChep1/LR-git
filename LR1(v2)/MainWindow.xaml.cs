using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using ClassLibrary1;

namespace LR1_v2_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Class1 JohnCos = new Class1(tBox_Cos.Text);
            if (JohnCos.isEmpty())
                lb_answer.Content = JohnCos.getCos();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            tBox_Cos.Clear();
            Class1 Clear = new Class1(tBox_Cos.Text);
            lb_answer.Content = Clear.Clear();

        }
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(tBox_Cos.Text, "[^0-9-,]")) 
            {
                tBox_Cos.Text = tBox_Cos.Text.Remove(tBox_Cos.Text.Length - 1);
                tBox_Cos.SelectionStart = tBox_Cos.Text.Length;
            }
        }
    }
}
