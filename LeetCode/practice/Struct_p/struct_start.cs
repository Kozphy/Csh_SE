using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Struct_p
{
    internal class struct_start
    {
        struct Game 
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public Game(string name,string developer, double rating, string releaseDate) { 
                this.name= name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate= releaseDate;
            }

            public void Display() { 
                Console.WriteLine($"Game 1's name is {this.name}");
                Console.WriteLine($"Game 1's developer is {this.developer}");
                Console.WriteLine($"Game 1's rating is {this.rating}");
                Console.WriteLine($"Game 1's releaseDate is {this.releaseDate}");
            }
        }
         
        public static void Start()
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();
        }
    }
}
