using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal class MediaContent
    {
        public void virtual StartPlayingContent() {
            Console.WriteLine("Start");
        }
        public void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public void PausePlayingContent() { Console.WriteLine("Pause"); }
        public void ContinuePlayingContent() { Console.WriteLine("Continue"); }
        public override string ToString()
        {
            Console.WriteLine("AudioContent ToString");
            return "OTT";
        }
    }
    // End of media Class
    internal class AudioContent : MediaContent
    {
       public override void StartPlayingContent()
        { 
            Console.WriteLine("Start"); 
        }
    }
    // End of AudioContent Class
    internal class VideoContent : AudioContent 
    {

    }
    // End of VideoContent Class
    internal class MediaTester
    {
        public static void TestOne() 
        {
            
        }
    }
    // End of the MediaTester Class
}
