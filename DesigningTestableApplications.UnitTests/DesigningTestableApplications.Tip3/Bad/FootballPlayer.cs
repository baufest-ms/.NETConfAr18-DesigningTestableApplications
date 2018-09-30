using System;

namespace DesigningTestableApplications.Tip3.Bad
{
    public class FootballPlayer : Player
    {
        public FootballPlayer() : base()
        {
        }

        public override void Walk()
        {
            this.Stamina -= 2;
        }

        public override void Run()
        {
            this.Stamina -= 10;
        }

        public override void Shoot()
        {
            this.Stamina -= 15;
        }

        public override void Tackle()
        {
            this.Stamina -= 10;
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Smash()
        {
            throw new NotImplementedException();
        }
    }
}
