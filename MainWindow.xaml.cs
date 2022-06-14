using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pach = 0;
       public string path1 = @"C:\Users\Stud\source\repos\WpfApp15\Img\Безымянный.png";
       public string path2 = @"C:\Users\Stud\source\repos\WpfApp15\Img\Безымянный2.png";
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if(pach==0)
            { kapcha.Source = new BitmapImage(new Uri(path1)); }

            
        }

        private void refreshKapcha_Click(object sender, RoutedEventArgs e)
        {
           if(pach == 1)
            {
                kapcha.Source = new BitmapImage(new Uri(path1));
                pach--;
            }
           else
           {
                kapcha.Source = new BitmapImage(new Uri(path2));
                pach++;
           }

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            DB.ContextDB contextDB = new DB.ContextDB();
            //DB.Users users = new DB.Users();
            List<DB.Users> users = contextDB.users.ToList();
            string logo = capha343.Text;
            foreach (var item in users)
            {
                if (tbLogin.Text == item.Name && tbPassword.Text == item.password )
                {
                    
                    
                   List<DB.Users> log = users.Where(x=>x.Name == tbLogin.Text).ToList();
                    MyWindow.Admin admin = new MyWindow.Admin(log[0]);
                    admin.Show();
                    this.Close();
                }
                if(logo=="")
                {
                    MessageBox.Show("прилождение заблокировалось на 10 сек");
                    Thread.Sleep(100);

                    
                }
            }
            

        }
    }
}
