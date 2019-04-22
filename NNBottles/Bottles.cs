using System.Globalization;
using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
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
            var bottleNumber = BottleNumber.For(number);
                
            return Capitalize($"{bottleNumber} of beer on the wall, {bottleNumber} of beer.") +
                   $"\n{bottleNumber.Action()}, {bottleNumber.Successor()} of beer on the wall.\n";
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