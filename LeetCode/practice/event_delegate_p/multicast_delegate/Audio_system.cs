using System;
namespace  ConsoleApp2.practice.event_delegate_p.multicast_delegate
{
    public class Audio_system
    {
        public void StartGame()
        {
            System.Console.WriteLine("Audio System Started");
            System.Console.WriteLine("Drawing Visuals...");
        }

        public void GameOver()
        {
            System.Console.WriteLine("Audio System Stopped");
        }
    }
}