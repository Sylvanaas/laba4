using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laaba4
{
    public class Bycycle
    {
        public string brandname;
        public string countryProd;
        public int NumOfWheel;
        public string color;
        public int size;
        public int price;
        public double getSellPrice()
        {
            return price * 0.5;
        }
    }
}
