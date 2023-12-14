namespace AZZ_LB_3_3
{
    public class OrcWarrior : Unit
    {
        public OrcWarrior(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OW";
        }
    }
}
