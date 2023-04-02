namespace DZ_CS_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ex1();
            // Ex2();
            // EX3();
            // Ex4();
        }
        static void Ex1() 
        {
            Product product = new();
            product.InputData();

            Product product1 = new("Chips", 15, 55);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(product.ToString());
            Console.WriteLine(product1.ToString());

            Console.WriteLine();
            Console.WriteLine();

            product1.LowPrice();
            Console.WriteLine(product1.ToString());
        }

        static void Ex2() 
        {
            Device[] device =
            {
                new Microwave("Microwawe oven"),
                new Car      ("Car Volkswagen"),
                new Ship     ("Titanic"),
                new Kettle   ("Kettle Bosch")
           };
            foreach (var item in device)
            {
                item.Show();
                item.Sound();
                item.Description();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void EX3() 
        {
            MusicalInstruments[] musicalInstruments =
            {
                new Violin  ("Stradivari violin", "Made by Antonio Stradivary",
                             "First Stradivary violin vas made in 1666 year"),

                new Trombone("Trombone","Trombone is a European woodwind instrument.",
                             "The appearance of the trombone dates back to the 15th century."),

                new Ukulele ("Ukulele","Ukulele - Hawaiian four-string guitar",
                             "The ukulele appeared in the Hawaiian Islands in the second half of the 19th century."),

                new Cello   ("Cello","The cello is a bowed musical instrument with 4 strings tuned in fifths: Cb Gb Dm Am",
                             "The appearance of the cello dates back to the beginning of the 16th century.")
            };

            foreach (var item in musicalInstruments)
            {
                item.Show();
                item.Desc();
                item.Sound();
                item.History();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void Ex4() 
        {
            Worker[] workers =
            {
                new President(),
                new Security (),
                new Engineer (),
                new Manager  (),
            };
            foreach (Worker worker in workers)
            {
                worker.Print();
            }
        }
    }
}