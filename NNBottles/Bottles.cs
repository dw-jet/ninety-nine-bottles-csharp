namespace NNBottles
{
    public class Bottles
    {
        public static string Verse(int verseNumber)
        {
            if (verseNumber == 2)
            {
                return $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." +
                       $"\nTake one down and pass it around, {verseNumber - 1} bottle of beer on the wall.\n";
            }
            else
            {
                return $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." +
                       $"\nTake one down and pass it around, {verseNumber - 1} bottles of beer on the wall.\n";
            }
        }
    }
}