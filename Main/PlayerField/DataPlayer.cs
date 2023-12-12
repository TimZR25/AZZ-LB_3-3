namespace AZZ_LB_3_3.Main.PlayerField
{
    public class DataPlayer : IDataPlayer
    {
        public string Name { get; set; }
        public TypeFaction Faction { get; set; }// сделать проверку для всего
        public int Score { get; set; }

        public DataPlayer(string name, TypeFaction faction, int score)
        {
            Name = name;
            Faction = faction;
            Score = score;
        }
    }
}