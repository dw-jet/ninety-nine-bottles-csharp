using System.Globalization;
using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
        private static string Container(int number)
        {
            return number == 1 ? "bottle" : "bottles";
        }
        private static string Pronoun(int number)
        {
            return number == 1 ? "it" : "one";
        }

        private static string Quantity(int number)
        {
            return number == 0 ? "no more" : number.ToString();
        }

        private static string Capitalize(string str)
        {
            // Capitalize the first letter of a string
            // in an efficient way
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            char[] charArray = str.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }
        public static string Verse(int number)
        {
            switch (number)
            {
                case 0:
                {
                    return $"{Capitalize(Quantity(number))} bottles of beer on the wall, no more bottles of beer." +
                           "\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";
                }
                default:
                {
                    return $"{Capitalize(Quantity(number))} {Container(number)} of beer on the wall, {number} {Container(number)} of beer." +
                           $"\nTake {Pronoun(number)} down and pass it around, {Quantity(number - 1)} {Container(number - 1)} of beer on the wall.\n";
                }
            }
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
