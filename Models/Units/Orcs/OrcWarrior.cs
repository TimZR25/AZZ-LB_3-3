namespace AZZ_LB_3_3
{
    public class OrcWarrior : Unit
    {
        public OrcWarrior()
        {
            Description = "Орк-воин умело командует войском";
        }

        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OW";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
