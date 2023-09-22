using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHelper.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace YoutubeHelper.Classes
{
    internal class CommandGetInfoAbout : ICommand
    {
        Receiver Receiver;
        string urlVideo;
        public static string nameCommand = "Получить информацию о видео";
        
        public CommandGetInfoAbout(Receiver receiver, string url)
        {
            Receiver = receiver;
            urlVideo = url;
        }

        public void Cancel()
        {
            
        }

        async public void Run()
        {

            Receiver.Operation();

            Console.WriteLine("Получение информации о видео");
            var youtube = YoutubeConnection.GetYoutubeConnection();
            var video = await youtube.Videos.GetAsync(urlVideo);
            

            Console.WriteLine();
            Console.WriteLine($"Информация о видео");
            Console.WriteLine($"Название видео: {video.Title}");
            Console.WriteLine($"Длительность видео: {video.Duration}");
            Console.WriteLine($"Описание: {video.Description}");

        }

    }
}
