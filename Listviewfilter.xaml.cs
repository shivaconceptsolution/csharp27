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

namespace WpfAdvanceControl
{
    /// <summary>
    /// Interaction logic for Listviewfilter.xaml
    /// </summary>
    public partial class Listviewfilter : Window
    {
        public Listviewfilter()
        {
            InitializeComponent();
            List<User1> items = new List<User1>();
            items.Add(new User1() { Name = "John Doe", Age = 42 });
            items.Add(new User1() { Name = "Jane Doe", Age = 39 });
            items.Add(new User1() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User1() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;
        }
            private bool UserFilter(object item)
		{
			if(String.IsNullOrEmpty(txtFilter.Text))
				return true;
			else
				return ((item as User1).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
		}

		private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
		}
	}

	
	public class User1
	{
		public string Name { get; set; }

		public int Age { get; set; }

		
	}


        }
    

