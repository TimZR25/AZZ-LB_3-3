namespace AZZ_LB_3_3
{
    public class OrcMage: Unit
    {
        public OrcMage(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
