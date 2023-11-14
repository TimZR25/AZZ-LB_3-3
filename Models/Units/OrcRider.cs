namespace AZZ_LB_3_3.Models.Units
{
    public class OrcRider: Unit
    {
        public OrcRider()
        {
            Description = "Орк наездник рвется в бой";
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
