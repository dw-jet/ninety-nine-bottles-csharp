using System.Globalization;
using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
        private static string Capitalize(object obj)
        {
            var str = obj.ToString();
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
            
            return $"{Capitalize(bottleNumber)} of beer on the wall, {bottleNumber} of beer." +
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