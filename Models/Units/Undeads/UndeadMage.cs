namespace AZZ_LB_3_3
{
    public class UndeadMage : Unit
    {
        public UndeadMage(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OM";
        }
    }
}
