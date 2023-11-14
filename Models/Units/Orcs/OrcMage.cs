namespace AZZ_LB_3_3
{
    public class OrcMage: Unit
    {
        public OrcMage() 
        {
            Description = "Орк-маг колдует заклинания";
        }
        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OM";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
