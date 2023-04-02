namespace DZ_CS_6
{
    internal abstract class Worker
    {
        public abstract void Print();
    }

    class President:Worker
    {
        public override void Print() => Console.WriteLine($"{nameof(President)}");

    }               

    class Security :Worker
    {
        public override void Print() => Console.WriteLine($"{nameof(Security)}");
    }               

    class Manager  :Worker
    {
        public override void Print() => Console.WriteLine($"{nameof(Manager)}");
    }               

    class Engineer :Worker
    {
        public override void Print() => Console.WriteLine($"{nameof(Engineer)}");
    }
}
