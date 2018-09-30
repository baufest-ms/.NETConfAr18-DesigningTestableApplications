namespace DesigningTestableApplications.Tip4
{
    public class Player
    {
        private bool isSelected = false;
        private int happiness = 0;

        public bool IsSelected
        {
            get 
            { 
                return this.isSelected; 
            }
        }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
        }

        public void Selected()
        {
            this.isSelected = true;
            this.happiness += 100;
        }
    }
}
