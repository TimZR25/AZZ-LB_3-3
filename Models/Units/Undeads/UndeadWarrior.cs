namespace AZZ_LB_3_3
{
    public class UndeadWarrior : Unit
    {
        public UndeadWarrior()
        {
            Description = "Нежить-воин умело командует войском";
            _distanceOfMove = 2;
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
