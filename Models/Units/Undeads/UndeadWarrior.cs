namespace AZZ_LB_3_3
{
    public class UndeadWarrior : Unit
    {
        public UndeadWarrior()
        {
            Description = "Нежить-воин умело командует войском";
            DistanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OW";
        }
    }
}
