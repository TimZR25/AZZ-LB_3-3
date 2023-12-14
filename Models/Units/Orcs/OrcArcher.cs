namespace AZZ_LB_3_3
{
    public class OrcArcher: Unit
    {
        public OrcArcher()
        {
            Description = "Орк-лучник стреляет из тяжелого лука";
            DistanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
