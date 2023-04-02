namespace DZ_CS_6
{
    internal abstract class MusicalInstruments
    {
        protected string? musicalInstrumentsName;
        protected string? musicalInstrumentsDescription;
        protected string? musicalInstrumentsHistory;

        public MusicalInstruments(string MusicalInstrumentsName, string MusicalInstrumentsDescription, string MusicalInstrumentsHistory)
        {
            musicalInstrumentsDescription = MusicalInstrumentsDescription;
            musicalInstrumentsHistory     = MusicalInstrumentsHistory;
            musicalInstrumentsName        = MusicalInstrumentsName;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

    }
    class Violin: MusicalInstruments
    {
        public Violin(string MusicalInstrumentsName, string MusicalInstrumentsDescription, string MusicalInstrumentsHistory): 
                      base(MusicalInstrumentsName, MusicalInstrumentsDescription, MusicalInstrumentsHistory) { }

        public override void Sound()   => Console.WriteLine("Violin sounds...");

        public override void Show()    => Console.WriteLine($"Instrument:\t{musicalInstrumentsName}");

        public override void Desc()    => Console.WriteLine($"Description:\t{musicalInstrumentsDescription}");

        public override void History() => Console.WriteLine($"History:\t{musicalInstrumentsHistory}");

    }

    class Trombone : MusicalInstruments
    {
        public Trombone(string MusicalInstrumentsName, string MusicalInstrumentsDescription, string MusicalInstrumentsHistory) :
                      base(MusicalInstrumentsName, MusicalInstrumentsDescription, MusicalInstrumentsHistory) { }

        public override void Sound()   => Console.WriteLine("Trombone sounds...");

        public override void Show()    => Console.WriteLine($"Instrument:\t{musicalInstrumentsName}");

        public override void Desc()    => Console.WriteLine($"Description:\t{musicalInstrumentsDescription}");

        public override void History() => Console.WriteLine($"History:\t{musicalInstrumentsHistory}");
    }

    class Ukulele : MusicalInstruments
    {
        public Ukulele(string MusicalInstrumentsName, string MusicalInstrumentsDescription, string MusicalInstrumentsHistory) :
                     base(MusicalInstrumentsName, MusicalInstrumentsDescription, MusicalInstrumentsHistory) { }

        public override void Sound()   => Console.WriteLine("Ukulele sounds...");

        public override void Show()    => Console.WriteLine($"Instrument:\t{musicalInstrumentsName}");

        public override void Desc()    => Console.WriteLine($"Description:\t{musicalInstrumentsDescription}");

        public override void History() => Console.WriteLine($"History:\t{musicalInstrumentsHistory}");
    }

    class Cello : MusicalInstruments
    {
        public Cello(string MusicalInstrumentsName, string MusicalInstrumentsDescription, string MusicalInstrumentsHistory) :
                    base(MusicalInstrumentsName, MusicalInstrumentsDescription, MusicalInstrumentsHistory)
        { }

        public override void Sound()   => Console.WriteLine("Cello sounds...");

        public override void Show()    => Console.WriteLine($"Instrument:\t{musicalInstrumentsName}");

        public override void Desc()    => Console.WriteLine($"Description:\t{musicalInstrumentsDescription}");

        public override void History() => Console.WriteLine($"History:\t{musicalInstrumentsHistory}");
    }

}
