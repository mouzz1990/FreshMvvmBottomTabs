using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fresh1.PageModels
{
    public class ExchangePageModel : FreshMvvm.FreshBasePageModel
    {
        public ExchangePageModel()
        {

        }

        private ICommand changeThemeCommand;
        public ICommand ChangeThemeCommand
        {
            get
            {
                return changeThemeCommand ?? (changeThemeCommand = new Command(() => 
                {
                    Random rnd = new Random();
                    int red = rnd.Next(255);
                    int green = rnd.Next(255);
                    int blue = rnd.Next(255);

                    Color color = Color.FromRgb(red, green, blue);
                    Color inverseColor = Color.FromRgb(255 -red, 255 -green, 255 -blue);

                    App.TabContainer.BarBackgroundColor = color;
                    App.TabContainer.BarTextColor = inverseColor;
                    
                    foreach (var p in App.TabContainer.TabbedPages)
                        (p.Parent as NavigationPage).BarBackgroundColor = color;
                }));
            }
        }


        private ICommand naviateNextCommand;
        public ICommand NaviateNextCommand
        {
            get
            {
                return naviateNextCommand ?? (naviateNextCommand = new Command(async () => 
                {
                    await CoreMethods.PushPageModel<BrandUniversePageModel>();
                }));
            }
        }

    }
}
