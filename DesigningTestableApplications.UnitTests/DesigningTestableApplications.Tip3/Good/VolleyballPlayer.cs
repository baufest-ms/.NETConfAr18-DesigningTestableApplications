namespace DesigningTestableApplications.Tip3.Good
{
    public class VolleyballPlayer : IPlayer, ISmash
    {
        public VolleyballPlayer()
        {
            this.Stamina = 100;
        }

        public double Stamina { get; set; }

        public void Walk()
        {
            this.Stamina -= 0.5;
        }

        public void Run()
        {
            this.Stamina -= 3;
        }

        public void Smash()
        {
            this.Stamina -= 11;
        }
    }
}
