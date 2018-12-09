using Acr.UserDialogs;
using Fresh1.PageModels;
using Fresh1.Pages;
using Fresh1.Services;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Fresh1
{
    public partial class App : Xamarin.Forms.Application
    {
        public Page ContactListPage { get; set; }
        public Page ExchangePage { get; set; }

        public static BottomFreshTabbedNavigationContainer TabContainer { get; set; }
        public static FreshNavigationContainer ContactsNavContainer { get; set; }
        public static FreshNavigationContainer ExchangeNavContainer { get; set; }

        public App()
        {
            InitializeComponent();

            InitIOC();

            TabContainer = new BottomFreshTabbedNavigationContainer();
            
            TabContainer.AddTab<ContactListPageModel>("Contacts", "icon.png");
            TabContainer.AddTab<ExchangePageModel>("Exchange", "icon.png");

            MainPage = TabContainer;
        }

        private void InitIOC()
        {
            FreshIOC.Container.Register<IUserDialogs>(UserDialogs.Instance);
            FreshIOC.Container.Register<IStringWorker>(new StringWorker());
            FreshIOC.Container.Register<IDataService, DataService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    public class BottomFreshTabbedNavigationContainer : FreshTabbedNavigationContainer
    {
        public BottomFreshTabbedNavigationContainer()
        {
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            
        }
    }
}
