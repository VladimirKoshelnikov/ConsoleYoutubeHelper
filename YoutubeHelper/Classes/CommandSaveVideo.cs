using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using YoutubeHelper.Interfaces;

namespace YoutubeHelper.Classes
{
    internal class CommandSaveVideo : ICommand
    {
        Receiver Receiver;
        string urlVideo;

        public static string nameCommand = "Сохранить видео";

        public CommandSaveVideo(Receiver receiver, string url)
        {
            Receiver = receiver;
            urlVideo = url; 
        }

        public void Cancel()
        {

            // Console.WriteLine("Отмена операции");
        }

        public async void Run()
        {

            Console.WriteLine("Запуск загрузки видео");
            var youtube = YoutubeConnection.GetYoutubeConnection();
            youtube.Videos.DownloadAsync(urlVideo, "video.mp4");
            Console.WriteLine("Видео загружено в папку с исполнительным файлом");

        }

    }
}
