using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoCambio.Views;
using Xamarin.Forms;

namespace TipoCambio
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Image splashImage;
        
        public MainPage()
        {

            InitializeComponent();

            NavigateToResult();
        }

        protected async void NavigateToResult()
        {
            await Task.Delay(2000);
            Application.Current.MainPage = new NavigationPage(new ResultPage());

        }
    }
}
