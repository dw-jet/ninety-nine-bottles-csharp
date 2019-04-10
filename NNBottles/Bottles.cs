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
            if (number == 1)
            {
                return "it";
            }
            else return "one";
        }
        public static string Verse(int number)
        {
            switch (number)
            {
                case 0:
                {
                    return "No more bottles of beer on the wall, no more bottles of beer." +
                           "\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";
                }
                case 1:
                {
                    return $"{number} {Container(number)} of beer on the wall, {number} {Container(number)} of beer." +
                           $"\nTake {Pronoun(number)} down and pass it around, no more bottles of beer on the wall.\n";
                }
                default:
                {
                    return $"{number} {Container(number)} of beer on the wall, {number} {Container(number)} of beer." +
                           $"\nTake {Pronoun(number)} down and pass it around, {number - 1} {Container(number - 1)} of beer on the wall.\n";
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
