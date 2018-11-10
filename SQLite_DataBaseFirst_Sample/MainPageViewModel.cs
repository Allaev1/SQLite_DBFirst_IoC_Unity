using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;
using SQLitePCL;

namespace SQLite_DataBaseFirst_Sample
{
    public class MainPageViewModel
    {
        NorthwindContext context = new NorthwindContext("Northwind.sqlite");
        ObservableCollection<Product> products;

        public MainPageViewModel()
        {
            using (SQLiteConnection db = new SQLiteConnection("Northwind.sqlite"))
            {
                products = new ObservableCollection<Product>(db.Table<Product>().ToList<Product>());
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return products; }
        }
    }
}
