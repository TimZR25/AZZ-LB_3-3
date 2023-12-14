namespace AZZ_LB_3_3
{
    public class UndeadArcher : Unit
    {
        public UndeadArcher(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
