namespace AZZ_LB_3_3
{
    public class HumanRider: Unit
    {
        public HumanRider()
        {
            Description = "Человек-наездник рвется в бой";
            _distanceOfMove = 4;
        }
        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OR";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
