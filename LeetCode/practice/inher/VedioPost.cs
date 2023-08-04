using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

namespace ConsoleApp2.practice.inher
{
    internal class VedioPost:Post
    {
        protected string? VideoURL;
        protected int Length;
        protected System.Timers.Timer? aTimer;

        public VedioPost() 
        {
            this.ID = 0;
            this.Title = "My First Post";
            this.IsPublic = true;
            this.SendByUsername = "Denis Panjuta";
        }

        public VedioPost(string title, bool isPublic,string sendByUsername, string videoURL, int length):base(title, isPublic, sendByUsername)
        { 
            this.ID = GetNextID();
            this.VideoURL = videoURL;
            this.Length = length;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                e.SignalTime
            );
        }


        public void Play() 
        {
            Console.WriteLine("Playing");

            // create a timer with 1 second interval
            aTimer = new System.Timers.Timer(1000);

            // Hook up the Elasped event for the timer.
            aTimer.Elapsed += OnTimedEvent;
            // Have the timer fire repeated events 
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press Any key to stop.");
            var keyboardInput = Console.ReadLine();
            Console.WriteLine(keyboardInput);
            Stop();
        }

        public void Stop()
        {
            Console.WriteLine("stopped at {0}'s", DateTime.Now);
            aTimer.Dispose();
        }

        public override string ToString() 
        { 
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.VideoURL, this.SendByUsername);
        }
    }
}
