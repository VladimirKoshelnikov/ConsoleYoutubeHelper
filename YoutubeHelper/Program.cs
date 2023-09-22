using System;
using System.IO;
using YoutubeHelper.Classes;

namespace YoutubeHelper
{
    class Program
    {
        static void Main(string[] args)
        {


            Sender sender = new Sender();   
            Receiver receiver = new Receiver();
            string urlVideo = String.Empty;

            Console.WriteLine("Введите ссылку для скачивания видева");
            urlVideo = Console.ReadLine();

            var commandGetInfoAbout = new CommandGetInfoAbout(receiver, urlVideo);
            var commandSaveVideo = new CommandSaveVideo(receiver, urlVideo);


            sender.SetCommand(commandGetInfoAbout);
            sender.Run();

            sender.SetCommand(commandSaveVideo);
            sender.Run();

            Console.ReadKey();

        }

    }
}
