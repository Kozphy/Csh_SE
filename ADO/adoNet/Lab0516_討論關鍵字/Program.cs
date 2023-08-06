namespace Lab0516_討論關鍵字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPokemon pika = new MyPokemon("pika", PokemonID.Pikachu);
            MyPokemon pondin = new MyPokemon("pondin", PokemonID.Pondin);
            MyPokemon duck = new MyPokemon("duck", PokemonID.Duck);
            pika.Skill();
            Console.WriteLine(pika.PID);
            pondin.Skill();
            Console.WriteLine(pondin.PID);
            duck.Skill();
            Console.WriteLine(duck.PID);
            Digimon digimon = new Digimon();
        }

        // 有 : 符號
        // HTML => 沒有
        // CSS => 有，屬性:值，選擇:hover，selector: persudo
        // javasciprt => 有，三元
        // C# => 有，繼承
        class Digimon : MyPokemon
        {
            public Digimon() { }
            private string digimonName;
            public string DigimonName
            {
                get { return this.digimonName; }
                set { this.digimonName = value; }
            }
            public void Skill()
            {
                Console.WriteLine("Digimon Fire");
            }
        }


        enum PokemonID
        {
            Pikachu = 25,
            Pondin = 26,
            Duck = 54
        }

        class MyPokemon
        {
            // properties
            private string PokemonName;
            private PokemonID pid;

            // constructor
            public MyPokemon() { }

            public MyPokemon(string pokemonName, PokemonID pid)
            {
                this.PokemonName = pokemonName;
                this.pid = pid;
            }

            public string pokemonName
            {
                get { return PokemonName; }
                set { PokemonName = value; }
            }


            public PokemonID PID
            {
                get { return this.pid; }
                set { this.pid = value; }
            }

            // method
            public string active() { return "123"; }
            public void Skill()
            {
                Console.WriteLine($"I'm {pokemonName}");
            }

        }
    }
}