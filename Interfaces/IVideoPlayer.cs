using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IVideoPlayer
    {
        void videoStart(Mp3 mp3);
        void videoStop(Mp3 mp3);
    }
}
