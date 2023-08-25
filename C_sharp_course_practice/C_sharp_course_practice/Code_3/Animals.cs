namespace C_sharp_course_practice.Code_3 
{
    class Animal
    {
        private string name;
        private string sound;

        public const string SHELTER = "Derek's Home for Animals";

        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        // Default Constructor
        public Animal() : this("No Name", "No Sound");

        public Animal(string name) : this(name, "No Sound")
        {
        }


        
        

    }

}

