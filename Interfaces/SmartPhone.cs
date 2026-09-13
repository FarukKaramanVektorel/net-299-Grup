using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SmartPhone : Phone,IMp3Player,IVideoPlayer
    {
        public override void call(string number)
        {
            Console.WriteLine($"{number} aranıyor..");
        }

        public void start(Mp3 mp3)
        {
            throw new NotImplementedException();
        }

        public void stop(Mp3 mp3)
        {
            throw new NotImplementedException();
        }

        public void videoStart(Mp3 mp3)
        {
            throw new NotImplementedException();
        }

        public void videoStop(Mp3 mp3)
        {
            throw new NotImplementedException();
        }
    }
}
