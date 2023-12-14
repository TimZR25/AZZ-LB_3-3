namespace AZZ_LB_3_3
{
    public class HumanWarrior : Unit
    {
        public HumanWarrior(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OW";
        }
    }
}
