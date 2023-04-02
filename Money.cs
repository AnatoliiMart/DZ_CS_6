namespace DZ_CS_6
{
    internal class Money
    {
        private int dollars;
        private int cents;

        public int Dollars { get => dollars; set => dollars = value; }
        public int Cents   { get => cents;   set => cents   = value; }

        public Money() {}

        public Money(int dollars, int cents) {this.dollars = dollars; this.cents   = cents;}




        public virtual void InputData()
        {
            Console.Write("Enter the whole part of the price:\t");
            dollars = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fractional part of the price:\t");
            cents = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString() => "Price is:\t" + dollars + "." + cents + " USD";
    }

    internal class Product: Money
    {
        string? productName;

        public Product() {}

        public Product(string? ProductName, int DollarsPrice, int CentsPrice) : 
                       base(DollarsPrice, CentsPrice) => 
            productName = ProductName; 

        public override void InputData()
        {
            Console.WriteLine("Enter the nsme of product:\t");
            productName = Console.ReadLine();

            Console.Write("Enter the whole part of the price:\t");
            Dollars = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fractional part of the price:\t");
            Cents = Convert.ToInt32(Console.ReadLine());
        }

        public void LowPrice()
        {
            int lowDollarPrice;
            int lowCentPrice;

            Console.WriteLine($"Low price for {productName} ");

            Console.Write("Enter how many dollars you want to reduce the price:\t");
            lowDollarPrice = Convert.ToInt32(Console.ReadLine());
            Dollars -= lowDollarPrice;

            Console.Write("Enter how many cents you want to reduce the price:\t");
            lowCentPrice = Convert.ToInt32(Console.ReadLine());
            Cents -= lowCentPrice;
        }

        public override string ToString() => "Product:\t" + productName + "\n"+ base.ToString();

    }
}
