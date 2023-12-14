namespace AZZ_LB_3_3
{
    public class HumanMage: Unit
    {
        public HumanMage(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
