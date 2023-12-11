using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main
{
    public class FirstStage//controller
    {

        public List<IDataPlayer> ListDataPlayer { get; set; }//NFS

        public FirstStage(IFirstStageView firstStageView)
        {//написать нормальный view
            ListDataPlayer = new List<IDataPlayer>();

        }

        public void CreateDataPlayer(string name, TypeFaction typeFacton, int TotalScore)
        {

            ListDataPlayer.Add(new DataPlayer(name, typeFacton, TotalScore));
        }
    }
}