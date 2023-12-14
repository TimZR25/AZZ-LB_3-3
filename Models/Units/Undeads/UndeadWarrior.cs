namespace AZZ_LB_3_3
{
    public class UndeadWarrior : Unit
    {
        public UndeadWarrior(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }


        public override string GetSign()
        {
            return "OW";
        }
    }
}
