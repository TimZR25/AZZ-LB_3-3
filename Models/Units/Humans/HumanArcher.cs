namespace AZZ_LB_3_3
{
    public class HumanArcher: Unit
    {
        public HumanArcher()
        {
            Description = "Человек-лучник стреляет из тяжелого лука";
            _distanceOfMove = 2;
        }
        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OA";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
