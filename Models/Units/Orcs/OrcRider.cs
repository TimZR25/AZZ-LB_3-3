namespace AZZ_LB_3_3
{
    public class OrcRider: Unit
    {
        public OrcRider()
        {
            Description = "Орк-наездник рвется в бой";
            _distanceOfMove = 4;
        }

        public override string GetSign()
        {
            return "OR";
        }
    }
}
