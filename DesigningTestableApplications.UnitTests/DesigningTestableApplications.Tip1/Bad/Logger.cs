namespace DesigningTestableApplications.Tip1.Bad
{
    public class Logger
    {
        public void LogMessage(string message)
        {
            //Log messsage here...
        }

        public string[] GetLast10Messages()
        {
            return new string[]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" 
            };
        }
    }
}
