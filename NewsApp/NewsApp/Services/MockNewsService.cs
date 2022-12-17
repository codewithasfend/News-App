using System;
using NewsApp.Model;
namespace NewsApp.Services
{
	public class MockNewsService
	{
		List<News> newsList = new()
		{
			new News(){ Id = 1, Title = "Elon Musk set to become number-one influencer on Twitter", Content = "In spite of recent controversies, Mr Musk's popularity on Twitter is undeniable and growing.\nOver the past 12 months, he has gained 268,303 followers a day, on average, according to Social Blade, and lost followers on only five days, which can all be linked to news events. He lost nearly 200,000 on 12 November, when major job cuts were announced at Twitter - and as he is likely to have gained new followers that day too, the actual number who unfollowed him must have been much higher. Elon Musk is now the main character on Twitter, social-media commentator Matt Navarra says.\nIn some ways, having a CEO who is a major influencer on the platform has some advantages because it makes him very accessible to people.\nVery few social-media chief executives are major influencers on their own websites.", ImageUrl = "https://ichef.bbci.co.uk/news/976/cpsprodpb/7E51/production/_127773323_608b24d8-f298-4802-8bc7-422ec2fa5f99.jpg"},
			new News(){ Id = 2 , Title = "Climate change: Dimming Earth, mustard shortages and other odd side-effects",Content = "Birdsong, snowdrops, blossom and midge bites - these are not things you associate with November in the north of England.\nBut these are just some of the milder side effects of a warming world.\nAs well as fuelling deadly floods and drought, rising temperatures are cited as a cause of spontaneous explosions of Siberian permafrost, mustard shortages and the planet becoming dimmer.", ImageUrl = "https://ichef.bbci.co.uk/news/976/cpsprodpb/0E9B/production/_127593730_gettyimages-566662433.jpg"}
		};

		public List<News> GetNews()
		{
			return newsList;
		}


		public MockNewsService()
		{
		}
	}
}

