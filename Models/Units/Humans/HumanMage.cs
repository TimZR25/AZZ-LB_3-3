namespace AZZ_LB_3_3
{
    public class HumanMage: Unit
    {
        public HumanMage() 
        {
            Description = "Человек-маг колдует заклинания";
            _distanceOfMove = 1;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
