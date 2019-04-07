namespace NNBottles
{
    public class Bottles
    {
        public static string Verse(int verseNumber)
        {
            switch (verseNumber)
            {
                case 1:
                {
                    return "1 bottle of beer on the wall, 1 bottle of beer." +
                           "\nTake it down and pass it around, no more bottles of beer on the wall.\n";
                }
                case 2:
                {
                    return $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." +
                           $"\nTake one down and pass it around, {verseNumber - 1} bottle of beer on the wall.\n";
                }
                default:
                {
                    return $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." +
                           $"\nTake one down and pass it around, {verseNumber - 1} bottles of beer on the wall.\n";
                }
            }
        }
    }
}
