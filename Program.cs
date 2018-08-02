using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Foobar foo = new Foobar();
            Processor processor = new Processor();
            processor.Process(foo);
            Console.WriteLine($"Foobar.Bar value = {foo.Bar}");
            Console.ReadKey();
        }
    }

    class Foobar {
        public string Bar = "FooBar";
    }

    class Processor {
        public void Process(Foobar foo) {
            foo.Bar = "some text";
        }
    }
}
