using EntryPoint.NewsTypes;
using EntryPoint.Recipients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint.Providers
{
    public class NewsProvider
    {
        private delegate void AddMethod(string message);

        private event AddMethod SubscribeNews;
        private event AddMethod SubscribeWeather;
        private event AddMethod SubscribeSport;
        private event AddMethod SubscribeAccident;
        private event AddMethod SubscribeHumor;

        public void SubscribeTo(Client client, Category category)
        {
            switch(category)
            {
                case Category.news: SubscribeNews += client.ShowNews;
                    break;
                case Category.weather:
                    SubscribeWeather += client.ShowNews;
                    break;
                case Category.sport:
                    SubscribeSport += client.ShowNews;
                    break;
                case Category.accidents:
                    SubscribeAccident += client.ShowNews;
                    break;
                case Category.humor:
                    SubscribeHumor += client.ShowNews;
                    break;
                default: Console.WriteLine("Такой категории нету!");
                    break;
            }
        }

        public void UnSubscribe(Client client, Category category)
        {
            switch (category)
            {
                case Category.news:
                    SubscribeNews -= client.ShowNews;
                    break;
                case Category.weather:
                    SubscribeNews -= client.ShowNews;
                    break;
                case Category.sport:
                    SubscribeNews -= client.ShowNews;
                    break;
                case Category.accidents:
                    SubscribeNews -= client.ShowNews;
                    break;
                case Category.humor:
                    SubscribeNews -= client.ShowNews;
                    break;
                default:
                    Console.WriteLine("Такой категории нету!");
                    break;
            }
        }

        public void AddNews(Category category,string message)
        {
            switch(category)
            {
                case Category.news: 
                    SubscribeNews?.Invoke(message);
                    break;
                case Category.weather:
                    SubscribeWeather?.Invoke(message);
                    break;
                case Category.sport:
                    SubscribeSport?.Invoke(message);
                    break;
                case Category.accidents:
                    SubscribeAccident?.Invoke(message);
                    break;
                case Category.humor:
                    SubscribeHumor?.Invoke(message);
                    break;
                default: Console.WriteLine("Такой категории нету!");
                    break;

            }
        }
    }
}
