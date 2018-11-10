using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_DataBaseFirst_Sample
{
    class MainPageViewModel
    {
        NorthwindContext context = new NorthwindContext("Northwind.sqlite");
        public MainPageViewModel()
        {
            
        }
    }
}
