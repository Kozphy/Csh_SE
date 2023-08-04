using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.linq_p
{
    class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }
    internal class select_many
    {
        public static void SetectManyEx()
        {
            PetOwner[] petOwners =
            {
                new PetOwner{
                    Name = "Higa",
                    Pets = new List<string> { "Scruffy", "Sam"}
                },
                new PetOwner {
                    Name ="Ashkenzi",
                    Pets= new List<string> {"Walker", "Suger"}
                },
                new PetOwner{
                    Name="Scratches",
                    Pets=new List<string>{"Scratches", "Diesel"}
                },
                new PetOwner
                {
                    Name="Hines",
                    Pets=new List<string>{"Dusty"}
                }
            };

            var query = petOwners.SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName });

            var query2 = petOwners.SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
                .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
                .Select(ownerAndPet => new
                {
                    Name = ownerAndPet.petOwner.Name,
                    Pet = ownerAndPet.petName,
                }
                );

            foreach (var q in query)
            {
                Console.WriteLine(q);
                Console.WriteLine("petOwnerName: " + q.petOwner.Name);
                Console.WriteLine("petName: " + q.petName);
            }

            Console.WriteLine();
            foreach (var q in query2)
            {
                Console.WriteLine(q);
            }
        }
    }
}
