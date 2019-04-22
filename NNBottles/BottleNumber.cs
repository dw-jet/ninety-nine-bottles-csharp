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

        public virtual string Container()
        {
            return "bottles";
        }
        public virtual string Pronoun()
        {
            return "one";
        }

        public virtual string Quantity()
        {
            return Number.ToString();
        }

        public virtual string Action()
        {
            return $"Take {Pronoun()} down and pass it around";
        }

        public virtual int Successor()
        {
            return Number - 1;
        }

        public override string ToString()
        {
            return $"{Quantity()} {Container()}";
        }
    }
}