namespace AZZ_LB_3_3
{
    public class OrcMage: Unit
    {
        public OrcMage() 
        {
            Description = "Орк-маг колдует заклинания";
            _distanceOfMove = 1;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
