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

namespace _06._09._2021
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

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.Text == "Search")
                {
                    tb.Text = tb.Text.Remove(0);
                    tb.Foreground = Brushes.Black;
                }
            }
        }
        private void TextBox_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Text = tb.Text.Remove(0);
                tb.Foreground = Brushes.Black;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.Name == "btnMsg")
                {
                    if (tb.Text == "Write a message...")
                    {
                        tb.Text = "";
                    }
                }
                else if (tb.Name == "btnSearch")
                {
                    if (tb.Text == "Search")
                    {
                        tb.Text = "";
                    }
                }
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb.Name == "btnMsg")
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                        tb.Text = "Write a message...";
                }
                else if (tb.Name == "btnSearch")
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                        tb.Text = "Search";
                }
            }
        }

        private void BtnPerson_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "btnPerson1")
                    personFullname.Content = lblPerson1.Content;
                else if (btn.Name == "btnPerson2")
                    personFullname.Content = lblPerson2.Content;
                else if (btn.Name == "btnPerson3")
                    personFullname.Content = lblPerson3.Content;
                else if (btn.Name == "btnPerson4")
                    personFullname.Content = lblPerson4.Content;
                else if (btn.Name == "btnPerson5")
                    personFullname.Content = lblPerson5.Content;
                else if (btn.Name == "btnPerson6")
                    personFullname.Content = lblPerson6.Content;
                else if (btn.Name == "btnPerson7")
                    personFullname.Content = lblPerson7.Content;
                else if (btn.Name == "btnPerson8")
                    personFullname.Content = lblPerson8.Content;
            }
        }
    }
}
