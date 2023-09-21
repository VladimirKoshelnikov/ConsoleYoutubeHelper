using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeHelper.Classes
{
    internal abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
