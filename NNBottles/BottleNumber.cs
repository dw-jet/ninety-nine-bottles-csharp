namespace NNBottles
{
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

        public override string ToString()
        {
            return $"{Quantity()} {Container()}";
        }
    }
}