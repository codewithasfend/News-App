using System;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsApp.View;
using NewsApp.Model;
using NewsApp.Services;
using System.Collections.ObjectModel;

namespace NewsApp.ViewModel
{
	public partial class NewsViewModel : ObservableObject
	{
		private NewsService newsService;
		public ObservableCollection<News> NewsCollection { get; set; } = new ObservableCollection<News>();
		public NewsViewModel(NewsService newsService)
		{
			this.newsService = newsService;
			GetNewsList();
		}

        private async void GetNewsList()
        {
		 	var news = await newsService.GetNewsAsync();
			foreach (var item in news)
			{
				NewsCollection.Add(item);
			}
        }

		[ObservableProperty]
		News selectedNews;


		[RelayCommand]
		void GoToDetails()
		{
			if (SelectedNews == null) return;
			Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}",
				new Dictionary<string, object>
				{
					{"News", SelectedNews}
				});
			SelectedNews = null;
		}

    }
}

