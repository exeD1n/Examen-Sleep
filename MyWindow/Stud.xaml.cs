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
    /// Логика взаимодействия для Stud.xaml
    /// </summary>
    public partial class Stud : Window
    {
        public Stud()
        {
            InitializeComponent();
        }

        private void DobaviProd_Click(object sender, RoutedEventArgs e)
        {
            DB.ContextDB context = new DB.ContextDB();
            DB.Product product = new DB.Product();
            product.NameProd = tbNameProd.Text;
            product.Cost = Convert.ToInt32(tbCostProd.Text);

            context.products.Add(product);
            context.SaveChanges();
            MessageBox.Show("DDD");
        }
    }
}
