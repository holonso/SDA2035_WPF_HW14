using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_WPF_HW14
{
    public enum IEnumTypeProduct
    {
        Food,
        Tech
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public double CostProduct { get; set; }
        public IEnumTypeProduct TypeProduct { get; set; }  
    }
}
