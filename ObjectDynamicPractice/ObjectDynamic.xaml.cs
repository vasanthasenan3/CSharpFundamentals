using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practices
{
    /// <summary>
    /// Interaction logic for ObjectDynamic.xaml
    /// </summary>
    public partial class ObjectDynamic : Window
    {
        public ObjectDynamic()
        {
            InitializeComponent();
        }

        private void objclick_Click(object sender, RoutedEventArgs e)
        {
            object value = 100;
            txtOutput.Text = "Object Type\n";
            txtOutput.Text += "Value: " + value + "\n";
            txtOutput.Text += "Data Type: " + value.GetType().Name;
        }

        private void dynamic_Click(object sender, RoutedEventArgs e)
        {
            dynamic value = 100;
            txtOutput.Text = "Dynamic Type\n";
            txtOutput.Text += "Value: " + value + "\n";
            txtOutput.Text += "Data Type: " + value.GetType().Name;
            value = "Hello Vasanth";
            txtOutput.Text += "\n\nChanged Value: " + value;
            txtOutput.Text += "\nData Type: " + value.GetType().Name;
        }
    }
}
