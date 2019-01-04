using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;
using Template10.Mvvm;

namespace SQLite_DBFirst_IoC_Unity
{
    public class MainPageViewModel : ViewModelBase
    {
        ObservableCollection<Products> products;

        public MainPageViewModel(SQLiteConnection northwind)
        {
            products = new ObservableCollection<Products>(northwind.Table<Products>());
        }

        public ObservableCollection<Products> Products
        {
            get { return products; }
        }
    }
}
