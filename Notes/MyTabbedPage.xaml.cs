using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            var navigationPage2 = new NavigationPage(new NotesPage());
            navigationPage2.IconImageSource = "schedule.png";
            navigationPage2.Title = "Schedule";

            var navigationPage = new NavigationPage(new MyPage1());
            navigationPage.IconImageSource = "main.png";
            navigationPage.Title = "Main";

            Children.Add(navigationPage);
            Children.Add(navigationPage2);
        }
    }
}
