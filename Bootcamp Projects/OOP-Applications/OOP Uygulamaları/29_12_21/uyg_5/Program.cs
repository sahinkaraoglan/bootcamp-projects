using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace uyg_5
{
    public class Video
    {
        public string Title { get; set; }
    }
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        public delegate void videoEncodedEventhandler(object source, VideoEventArgs args);
    }
    public     class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
