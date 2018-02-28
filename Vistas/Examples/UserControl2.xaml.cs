using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Vistas.Examples
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {

        class User { public string FirstName, LastName; }
        public UserControl2()
        {
            InitializeComponent();
            ObservableCollection<User> users = new ObservableCollection<User>();
            users.Add(new User { FirstName = "firstname-1", LastName = "lastname-1" });
            users.Add(new User { FirstName = "firstname-2", LastName = "lastname-2" });
            users.Add(new User { FirstName = "firstname-3", LastName = "lastname-3" });
            users.Add(new User { FirstName = "firstname-4", LastName = "lastname-4" });
            dataGrid.ItemsSource = users;
        }
    }
}
