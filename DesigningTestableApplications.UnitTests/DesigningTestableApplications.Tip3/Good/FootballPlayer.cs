namespace DesigningTestableApplications.Tip3.Good
{
    public class FootballPlayer : IPlayer, IShoot, ITackle
    {
        public FootballPlayer()
        {
            this.Stamina = 100;
        }

        public double Stamina { get; set; }

        public void Walk()
        {
            this.Stamina -= 2;
        }

        public void Run()
        {
            this.Stamina -= 10;
        }

        public void Shoot()
        {
            this.Stamina -= 15;
        }

        public void Tackle()
        {
            this.Stamina -= 10;
        }
    }
}
