namespace AZZ_LB_3_3
{
    public class HumanRider : Unit
    {
        public HumanRider(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
