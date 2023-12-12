namespace AZZ_LB_3_3
{
    public class HumanRider : Unit
    {
        public HumanRider()
        {
            Description = "Человек-наездник рвется в бой";
            _distanceOfMove = 4;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
