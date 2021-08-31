using EntryPoint.NewsTypes;
using EntryPoint.Providers;
using EntryPoint.Recipients;
using System;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new NewsProvider();

            var client = new Client();

            var client2 = new Client();

            provider.SubscribeTo(client, Category.news);

            provider.SubscribeTo(client2, Category.humor);
            provider.SubscribeTo(client2, Category.news);

            provider.AddNews(Category.news, "Новости");
            provider.AddNews(Category.humor, "Юмор");

            
        }
    }
}
