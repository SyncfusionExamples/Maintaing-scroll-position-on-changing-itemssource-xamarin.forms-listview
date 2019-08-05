# Maintain the scroll position when updating ItemsSource at runtime

The SfListView have scrolled to top automatically when changing the ItemsSource at runtime. However, you can maintain the same scrolled position by using the `ScrollY` value of ExtendedScrollView from the [VisualContainer](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.VisualContainer.html). After changing the ItemsSource, you can pass the ScrollY value to [ScrollTo](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~ScrollTo.html) method of SfListView and scroll back to the same position.

For horizontal orientation, use the `ScrollX` value of ExtendedScrollView.

By using [Reflection](https://msdn.microsoft.com/en-us/library/system.reflection(v=vs.110).aspx), get the value of `ScrollOwner` from `VisualContainer` and use it.

```
using Syncfusion.ListView.XForms.Control.Helpers;
public partial class MainPage : ContentPage
{
    ExtendedScrollView scrollView;

    public MainPage()
    {
        InitializeComponent();
        scrollView = listView.GetScrollView();
    }

    private void ChangeItemsSource_Clicked(object sender, EventArgs e)
    {
        var viewModel = new ContactsViewModel();
        listView.ItemsSource = viewModel.EmployeeInfo;
        listView.ScrollTo(scrollView.ScrollY);
    }
}
```

To know more about Scrolling in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/scrolling)