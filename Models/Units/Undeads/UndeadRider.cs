namespace AZZ_LB_3_3
{
    public class UndeadRider : Unit
    {
        public UndeadRider()
        {
            Description = "Нежить-наездник рвется в бой";
            DistanceOfMove = 4;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
