namespace DesigningTestableApplications.Tip3.Bad
{
    public abstract class Player
    {
        public Player()
        {
            this.Stamina = 100;
        }

        public double Stamina { get; set; }

        public abstract void Walk();

        public abstract void Run();

        public abstract void Shoot();

        public abstract void Tackle();

        public abstract void Drive();

        public abstract void Smash();
    }
}
