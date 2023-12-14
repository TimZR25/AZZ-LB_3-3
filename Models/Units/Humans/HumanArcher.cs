namespace AZZ_LB_3_3
{
    public class HumanArcher: Unit
    {
        public HumanArcher()
        {
            Description = "Человек-лучник стреляет из тяжелого лука";
            DistanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
