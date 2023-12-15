using HuamanS14.DataContext;
using HuamanS14.Interfaces;
using HuamanS14.ViewModels;
using HuamanS14.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuamanS14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new CompraView();
            GetContext().Database.EnsureCreated();
        }
        public static AppDbContext GetContext()
        {
           
            string DbPath = DependencyService.Get<IConfigDatabase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
