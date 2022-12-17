using NewsApp.ViewModel;

namespace NewsApp.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel newsDetailViewModel)
	{
		InitializeComponent();
		BindingContext = newsDetailViewModel;
	}
}
