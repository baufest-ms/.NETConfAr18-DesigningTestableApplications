using System.Collections.Generic;

namespace DesigningTestableApplications.Tip5
{
    public class Coach
    {
        public List<IPlayer> Players { get; set; }

        public Coach()
        {
            this.Players = new List<IPlayer>();
        }

        public void SelectPlayerForMatch(IPlayer player)
        {
            player.Selected();
            this.Players.Add(player);
        }
    }
}
