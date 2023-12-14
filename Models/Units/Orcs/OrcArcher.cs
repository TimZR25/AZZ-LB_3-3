namespace AZZ_LB_3_3
{
    public class OrcArcher: Unit
    {
        public OrcArcher(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
