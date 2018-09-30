namespace DesigningTestableApplications.Tip3.Good
{
    public class TennisPlayer : IPlayer, IDrive, ISmash
    {
        public TennisPlayer()
        {
            this.Stamina = 100;
        }

        public double Stamina { get; set; }

        public void Walk()
        {
            this.Stamina -= 1;
        }

        public void Run()
        {
            this.Stamina -= 5;
        }

        public void Drive()
        {
            this.Stamina -= 3;
        }

        public void Smash()
        {
            this.Stamina -= 8;
        }
    }
}
