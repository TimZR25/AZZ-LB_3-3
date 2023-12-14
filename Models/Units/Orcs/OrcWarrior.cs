namespace AZZ_LB_3_3
{
    public class OrcWarrior : Unit
    {
        public OrcWarrior()
        {
            Description = "Орк-воин умело командует войском";
            DistanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OW";
        }
    }
}
