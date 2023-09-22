using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeHelper.Interfaces
{
    internal interface ICommand
    {
        public void Run();
        public void Cancel();
    }
}
