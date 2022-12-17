using NewsApp.ViewModel;
namespace NewsApp.View;

public partial class NewsPage : ContentPage
{
	public NewsPage(NewsViewModel newsViewModel)
	{
		InitializeComponent();
		BindingContext = newsViewModel;
	}
}
