using System;

namespace Interpreters {

    class NumeralInterpreter {

        

    }

    abstract class Expression {

        public void Interpret(Context  context) {

            if (string.IsNullOrWhiteSpace(context.Input)) return;


        }

    }

    class Context {
        private string _input;
        private int _output;

        public Context(string input) {
            _input = input;
        }

        public string Input {
            get { return  _input; }
            set { _input = value; }
        }

        public int Output {
            get { return _output; }
            set { _output = value; }
        }

        
    }

    class Number {

    }
    class One : Number {

    }
    class Two : Number {

    }
    class Three: Number {
    }
    class Four : Number {

    }
    class Five  : Number {

    }
    class Six  : Number {

    }
    class Seven : Number {

    }
    class Eight : Number {

    }
    class Nine : Number {

    }
    class Ten : Number {

    }
    class Eleven : Number {

    }
    class Twelve : Number {

    }
    class Thirteen : Number {

    }
    class Fourteen : Number {

    }
    class Fifteen : Number {

    }
    class Sixteen : Number {

    }
    class Seventeen : Number {

    }
    class Eighteen : Number {

    }
    class Nineteen : Number {

    }
    class Twenty : Number {

    }
    class Thirty : Number {

    }
    class Fourty : Number {

    }
    class Fifty : Number {

    }
    class Sixty : Number {

    }
    class Seventy : Number {

    }
    class Eighty : Number {

    }
    class Ninety : Number {

    }
    class Hundred : Number {

    }
    class Thousand : Number {

    }
    class Million : Number {

    }
    class Billion : Number {

    }
    class Trillion : Number {

    }
    class Quadrillion : Number {

    }
    


    class NumberMap {
        enum Numbers {
            One,
            Ten,
            Hundred,
            Thousand,
            TenThousand,
            HundredThousand,
            Million,


        }
        enum triplets {
            Thousand = 3,
            Million = 6,
            Billion = 9,
            Trillion = 12,
            Quadrillion = 15,
            Quintillion = 18,
            Sextillion = 21,
            Septillion = 24,
            Octillion = 27,
            Nonillion = 30,
            Decillion = 33,
            Undecillion = 36,
            Duodecillion = 39,
            Tredecillion = 42,
            Quatttuordecillion = 45,
            Quindecillion = 48,
            Sexdecillion = 51,
            Septendecillion = 54,
            Octodecillion = 57,
            Novemdecillion = 60,
            Vigintillion = 63,

        }
    }

    class OneExpression : Expression 
    {
        public string Zero() { return "zero"; }
        public string One() { return "one"; }
        public string Two() { return "two"; }
        public string Three() { return "three"; }
        public string Four() { return "four"; }
        public string Five() { return "five"; }
        public string Six() { return "six"; }
        public string Seven() { return "seven"; }
        public string Eight() { return "eight"; }
        public string Nine() { return "nine"; }
        public int Multiplier() { return 1; }

    }

    class TenExpression : Expression 
    {
        public string Zero() { return "ten"; }
        public string One() { return "eleven"; }
        public string Two() { return "twelve"; }
        public string Three() { return "thirteen"; }
        public string Four() { return "fourteen"; }
        public string Five() { return "fifteen"; }
        public string Six() { return "sixteen"; }
        public string Seven() { return "seventeen"; }
        public string Eight() { return "eighteen"; }
        public string Nine() { return "nineteen"; }
        public int Multiplier() { return 10; }

    }



}