using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeHelper.Classes
{
    /// <summary>
    /// Реализуем синглтон для создания подключения к Youtube
    /// </summary>
    abstract class YoutubeConnection
    {
        private static YoutubeClient _youtubeConnection;

        private YoutubeConnection()
        {

        }

        public static YoutubeClient GetYoutubeConnection()
        {
            if (_youtubeConnection == null)
            {
                _youtubeConnection = new YoutubeClient();
            }
            return _youtubeConnection;
        }

    }
}
