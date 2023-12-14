using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public class HumanArcher: Unit
    {
        public HumanArcher(IUnitStats unitStats)
        {
            UnitStats = unitStats;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
