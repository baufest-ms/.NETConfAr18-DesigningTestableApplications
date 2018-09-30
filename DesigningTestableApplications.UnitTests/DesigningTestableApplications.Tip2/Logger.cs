namespace DesigningTestableApplications.Tip2
{
    public class Logger : ILogger
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
