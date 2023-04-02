namespace DZ_CS_6
{
    internal abstract class Device 
    {
        private string? _name;

        public  string? Name { get => _name; set => _name = value; }

        public Device() { }

        public Device(string? name)
        {
            _name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Device sounds...");
        }

        public virtual void Show() 
        {
            Console.WriteLine("This is:\t" + Name);
        }

        public virtual void Description() 
        {
            Console.WriteLine("Non typed device!");
        }
    }

    internal class Microwave : Device
    {
        public Microwave(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Microwave sounds...");
        }

        public override void Show()
        {
            Console.WriteLine("This is:\t" + Name);
        }

        public override void Description()
        {
            Console.WriteLine("Microwave need for heat the dishes");
        }
    }

    internal class Car : Device
    {
        public Car(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Car sounds...");
        }

        public override void Show()
        {
            Console.WriteLine("This is:\t" + Name);
        }

        public override void Description()
        {
            Console.WriteLine("Car need for travel on roads");
        }
    }

    internal class Ship : Device
    {
        public Ship(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Ship sounds...");
        }

        public override void Show()
        {
            Console.WriteLine("This is:\t" + Name);
        }

        public override void Description()
        {
            Console.WriteLine("Ship need for sea travels");
        }
    }

    internal class Kettle : Device
    {
        public Kettle(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Kettle sounds...");
        }

        public override void Show()
        {
            Console.WriteLine("This is:\t" + Name);
        }

        public override void Description()
        {
            Console.WriteLine("Kettle need for make tea/coffee!");
        }
    }
}
