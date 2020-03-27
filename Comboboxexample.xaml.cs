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
using System.Windows.Shapes;
using System.Reflection;

namespace WpfAdvanceControl
{
    /// <summary>
    /// Interaction logic for Comboboxexample.xaml
    /// </summary>
    public partial class Comboboxexample : Window
    {
        public Comboboxexample()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


           
           // String s1 = cmbColors.SelectedValue.ToString().Substring(cmbColors.SelectedValue.ToString().LastIndexOf(" ")).Trim();
           // MessageBox.Show(cmbColors.SelectedValue.GetType().Name.ToString());
            //Color c = (Color)ColorConverter.ConvertFromString(s1);
            Color c = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(null, null);
            this.Background = new SolidColorBrush(c);
        }
    }
}
