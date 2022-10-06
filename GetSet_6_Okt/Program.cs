namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getter och Setters används endast i klasser för att göra dem mer säkra
            // Vilken typ av data som är relevant till vilka attribut och vad är ej

            Bok book1 = new Bok(); // Vi skapar ett objekt av vår klass och kallar på vår Constructor genom Book(); (om det finns någon)
            book1.title = "hej";
            book1.author = "Hugo";
            book1.pages = 200;

            BokTwo bok1 = new BokTwo("Hej", "Cool", 199);

            Car carObject = new Car(); // Vi skapar ett Objekt av vår klass och vår Construktor kallas på om vi har någon
            carObject.Hej = "hejhej";
            Console.WriteLine(carObject.Hej);

            CarTwo cartwo = new CarTwo();
            cartwo.Yoo = "looo";
            Console.WriteLine(cartwo.Yoo);

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR - De enda ratings som våra filmer skall kunna få


            avengers.Rating = "Bajs";
            Console.WriteLine(avengers.Rating); // Rating NR skrivs ut tack våre vår setter's IF statement 
        }

        class Bok // I denna klassen måste vi skriva 4 linjer kod för att skapa våra Objekt (rad 10 -13)
        {
            public string title;
            public string author;
            public int pages;

            public Bok() // Constructor = en speciell metod för Klasser som kallas på när vi skapar ett objekt av den klassen 
            {
                Console.WriteLine("hej");
            }
        }

        class BokTwo
        {
            public string title;
            public string author;
            public int pages;

            public BokTwo(string aTitle, string aAuthor, int aPages) // Constructor - vi sätter in parametrar i constructorn så vi kan skriva våra objekt snyggare (rad 15)
            {
                title = aTitle;
                author = aAuthor;
                pages = aPages;
            }
        }


        class Car
        {
            private string hej;

            public string Hej
            {
                get
                {
                    return hej; // Efter det returnerar man värdet dit man kallar på det
                }
                set
                {
                    hej = value; // Först sätter man värdet av hej = Value
                }
            }
        }

        class CarTwo
        {
            public string Yoo { get; set; } // Enklare sätt att skriva det på! 
        }

        class Movie
        {
            public string title; // public = alla har tillgång till dem och kan ändra om de vill
            public string director;
            private string rating; // private = endast kod inuti denna klassen (Movie) har tillgång till denna 

            public Movie(string aTitle, string aDirector, string aRating) // Constructor = en speciell metod för Klasser som kallas på när vi skapar ett objekt av den klassen
            {
                this.title = aTitle;
                this.director = aDirector;
                this.rating = aRating;
            }
                        
            public string Rating // Property = likt en metod men som gör det möjligt för oss att använda getter och setters - Samma namn som fält fast med stor bokstav
            {
                get { return rating; } // I din setter kan du skapa regler
                set { 
                    if (value == "G" || value ==  "PG" || value == "PG-13" || value == "R" || value == "NR")
                    {
                        rating = value;
                    } else
                    {
                        rating = "NR";
                    }
                } 
            }
        }
    }
}