using System;

namespace  ConsoleApp2.practice.event_delegate_p.multicast_delegate
{
    public class Player {
        private string? _PlayerName;

        public string PlayerName{
            get => _PlayerName!;
            set => _PlayerName = value;
        }

       public Player(string name) 
       {
            this._PlayerName = name;
       }

        public void StartGame()
        {
            System.Console.WriteLine($"Spawning Player with ID: {_PlayerName}");
        }

        public void GameOver()
        {
            System.Console.WriteLine($"Removing Player with ID: {_PlayerName}");
        }
    }
}