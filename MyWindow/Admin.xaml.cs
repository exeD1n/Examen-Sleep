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

namespace WpfApp15.MyWindow
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public static DB.Users users1;
        public Admin(DB.Users users)
        {
            users1 = users;
            InitializeComponent();
            this.Loaded += Admin_Loaded;
        }

        private void Admin_Loaded(object sender, RoutedEventArgs e)
        {
            NameChelLB.Content = users1.LastName;
            PasswordLB.Content = users1.NameUser;

        }

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Stud stud = new MyWindow.Stud();
            stud.Show();
            this.Close();
        }
    }
}
