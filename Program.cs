namespace DZ_CS_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


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
    }
}