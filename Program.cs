using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            Foobar foo = new Foobar();
            Processor processor = new Processor();
            processor.Process(ref foo);
            Console.WriteLine($"Foobar.Bar value = {foo.Bar}");
            Console.ReadKey();
        }
    }

    class Foobar {
        public string Bar = "FooBar";
    }

    class Processor {
        public void Process(ref Foobar foo) {
            foo.Bar = "some text";
        }
    
    }

    class SomeBuilder {

    }

    interface Entry {
        Entry Entry ();

    }

    

}
