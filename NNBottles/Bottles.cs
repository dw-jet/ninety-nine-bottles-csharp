using System.Text;

namespace NNBottles
{
    public static class Bottles
    {
        private static string Container(int number)
        {
            return number == 1 ? "bottle" : "bottles";
        }
        public static string Verse(int verseNumber)
        {
            switch (verseNumber)
            {
                case 0:
                {
                    return "No more bottles of beer on the wall, no more bottles of beer." +
                           "\nGo to the store and buy some more, 99 bottles of beer on the wall.\n";
                }
                case 1:
                {
                    return "1 bottle of beer on the wall, 1 bottle of beer." +
                           "\nTake it down and pass it around, no more bottles of beer on the wall.\n";
                }
                default:
                {
                    return $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." +
                           $"\nTake one down and pass it around, {verseNumber - 1} {Container(verseNumber - 1)} of beer on the wall.\n";
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
