using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeHelper.Interfaces;

namespace YoutubeHelper.Classes
{
    internal class Sender
    {
        ICommand command;
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        async public Task Run()
        {
            command.Run();
        }
        public void Cancel()
        {
            command.Cancel();
        }
    }
}
