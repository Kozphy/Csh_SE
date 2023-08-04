using System;

namespace  ConsoleApp2.practice.event_delegate_p.multicast_delegate
{
    public class RenderEngine{
        public void StartGame()
        {
            System.Console.WriteLine("Render Engine Started");
            System.Console.WriteLine("Drawing Visuals...");
        }

        public void GameOver()
        {
            System.Console.WriteLine("Rendering Engine Stopped");
        }
    }
}