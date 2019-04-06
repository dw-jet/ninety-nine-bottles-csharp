namespace NNBottles
{
    public class Bottles
    {
        public string Verse(int verseNumber)
        {
            return
                $"{verseNumber} bottles of beer on the wall, {verseNumber} bottles of beer." + 
                $"\nTake one down and pass it around, {verseNumber-1} bottles of beer on the wall.\n"; 
        } 
    }
}