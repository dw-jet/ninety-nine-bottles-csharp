namespace NNBottles
{
    class BottleNumber6 : BottleNumber
    {
        public BottleNumber6(int number) : base(number)
        {
        }
        
        public override string Container()
        {
            return "six-pack";
        }        
        public override string Quantity()
        {
            return "1";
        }        
    }
}