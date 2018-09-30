using System;

namespace DesigningTestableApplications.Tip3.Bad
{
    public class TennisPlayer : Player
    {
        public TennisPlayer() : base()
        {
        }

        public override void Walk()
        {
            this.Stamina -= 1;
        }

        public override void Run()
        {
            this.Stamina -= 5;
        }

        public override void Shoot()
        {
            throw new NotImplementedException();
        }

        public override void Tackle()
        {
            throw new NotImplementedException();
        }

        public override void Drive()
        {
            this.Stamina -= 3;
        }

        public override void Smash()
        {
            this.Stamina -= 8;
        }
    }
}
