namespace AZZ_LB_3_3
{
    public class UndeadRider : Unit
    {
        public UndeadRider(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
