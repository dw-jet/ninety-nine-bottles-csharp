using System.Globalization;
using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
        private static string Capitalize(string str)
        {
            // Capitalize the first letter of a string
            // in an efficient way
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            var charArray = str.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }
        public static string Verse(int number)
        {
            var bottleNumber = new BottleNumber(number);
            // Shameless solution to finish the horizontal refactoring
            // The problem is that Successor should return a new BottleNumber
            var nextBottleNumber = new BottleNumber(bottleNumber.Successor());
            
            return $"{Capitalize(bottleNumber.Quantity())} {bottleNumber.Container()} of beer on the wall, {bottleNumber.Quantity()} {bottleNumber.Container()} of beer." +
                   $"\n{bottleNumber.Action()}, {nextBottleNumber.Quantity()} {nextBottleNumber.Container()} of beer on the wall.\n";
        }

        public static string Verses(int startVerse, int endVerse)
        {
            var verseBuilder = new StringBuilder();
            for (var i = startVerse; i>= endVerse; i--)
            {
                verseBuilder.Append(Verse(i) + "\n");
            }
            return verseBuilder.ToString();
        }

        public static string Song()
        {
            return Verses(99, 0);
        }
    }

    public class BottleNumber
    {
        public BottleNumber(int number)
        {
            _number = number;
        }
        
        private int _number;

        public int Number => _number;

        public string Container()
        {
            return Number == 1 ? "bottle" : "bottles";
        }
        public string Pronoun()
        {
            return Number == 1 ? "it" : "one";
        }

        public string Quantity()
        {
            return Number == 0 ? "no more" : Number.ToString();
        }

        public string Action()
        {
            return Number == 0 ? "Go to the store and buy some more" : $"Take {Pronoun()} down and pass it around";
        }

        public int Successor()
        {
            return Number == 0 ? 99 : Number - 1;
        }
    }
}