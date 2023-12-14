namespace AZZ_LB_3_3
{
    public class OrcRider: Unit
    {
        public OrcRider(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
