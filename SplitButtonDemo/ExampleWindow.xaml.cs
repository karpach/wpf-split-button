using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace SplitButtonDemo
{
    /// <summary>
    /// Interaction logic for WindowExample.xaml
    /// </summary>

    public partial class WindowExample : System.Windows.Window
    {

        public WindowExample()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(Object sender, RoutedEventArgs e)
        {
            var menu = e.OriginalSource as MenuItem;
            menu.Background = Brushes.Yellow;            
        }

        private void SplitButton_Click(Object sender, RoutedEventArgs e)
        {
            var menu = e.OriginalSource as MenuItem;
            foreach (MenuItem item in menu.Items)
            {
                item.Background = Brushes.Transparent;
            }
        }
    }
}