using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;
using Template10.Mvvm;

namespace SQLite_DataBaseFirst_Sample
{
    public class MainPageViewModel : ViewModelBase
    {
        ObservableCollection<Product> products;

        public MainPageViewModel(SQLiteConnection northwind)
        {
            products = new ObservableCollection<Product>(northwind.Table<Product>());
        }

        public ObservableCollection<Product> Products
        {
            get { return products; }
        }
    }
}
