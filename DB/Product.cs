using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.DB
{
    public class Product
    {
        [Key]
        public int IDproduct { set; get; }
        public string NameProd { get; set; }
        public int Cost { get; set; }


    }
}
