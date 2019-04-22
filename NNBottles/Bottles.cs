using System.Globalization;
using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
        public static BottleNumber BottleNumberFor(int number)
        {
            switch (number)
            {
                case 0:
                    return new BottleNumber0(number);
                case 1:
                    return new BottleNumber1(number);
                default:
                    return new BottleNumber(number);
            }
        }
        private static string Capitalize(string str)
        {
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
            var bottleNumber = BottleNumberFor(number);
            // Shameless solution to finish the horizontal refactoring
            // The problem is that Successor should return a new BottleNumber
            var nextBottleNumber = BottleNumberFor(bottleNumber.Successor());
            
            return Capitalize($"{bottleNumber} of beer on the wall, {bottleNumber} of beer.") +
                   $"\n{bottleNumber.Action()}, {nextBottleNumber} of beer on the wall.\n";
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
}