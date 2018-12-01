using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Template10.Common;
using GalaSoft.MvvmLight.Ioc;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using SQLite;

namespace SQLite_DataBaseFirst_Sample
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : BootStrapper
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<SQLiteConnection>(() => { return new SQLiteConnection("Northwind.sqlite"); });

            NavigationService.Navigate(typeof(MainPage));

            return Task.CompletedTask;
        }

        public override INavigable ResolveForPage(Page page, NavigationService navigationService)
        {
            if (page is MainPage)
                return SimpleIoc.Default.GetInstance<MainPageViewModel>();
            else
                return base.ResolveForPage(page, navigationService);
        }
    }
}
