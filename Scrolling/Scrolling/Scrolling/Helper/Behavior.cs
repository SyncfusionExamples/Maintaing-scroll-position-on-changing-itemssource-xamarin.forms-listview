using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewSample
{
    public class Behavior :Behavior<ContentPage>
    {

        Button button;
        ExtendedScrollView scrollview;
        SfListView ListView;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            button = bindable.FindByName<Button>("Button");
            scrollview = ListView.GetScrollView();
            button.Clicked += Button_Clicked;
            base.OnAttachedTo(bindable);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var viewmodel = new ContactsViewModel();
            ListView.ItemsSource = viewmodel.EmployeeInfo;
            ListView.ScrollTo(scrollview.ScrollY);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            button.Clicked -= Button_Clicked;
            base.OnDetachingFrom(bindable);
        }
    }
}
