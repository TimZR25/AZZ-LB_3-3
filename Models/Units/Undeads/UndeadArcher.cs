namespace AZZ_LB_3_3
{
    public class UndeadArcher : Unit
    {
        public UndeadArcher()
        {
            Description = "Нежить-лучник стреляет из тяжелого лука";
            _distanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OA";
        }
    }
}
