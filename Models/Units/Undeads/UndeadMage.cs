namespace AZZ_LB_3_3
{
    public class UndeadMage : Unit
    {
        public UndeadMage() 
        {
            Description = "Нежить-маг колдует заклинания";
            DistanceOfMove = 1;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
