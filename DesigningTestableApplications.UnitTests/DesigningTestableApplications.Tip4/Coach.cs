using System.Collections.Generic;

namespace DesigningTestableApplications.Tip4
{
    public class Coach
    {
        public List<Player> Players { get; set; }

        public Coach()
        {
            this.Players = new List<Player>();
        }

        public void SelectPlayerForMatch(Player player)
        {
            player.Selected();
            this.Players.Add(player);
        }
    }
}
