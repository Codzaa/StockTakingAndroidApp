using StockTaking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockTaking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompaniesPage : ContentPage
    {
        public CompaniesPage()
        {
            InitializeComponent();
        }
        //
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var vm = BindingContext as CompaniesViewModel;
            //
            vm.OnAppearing();

        }
    }
}