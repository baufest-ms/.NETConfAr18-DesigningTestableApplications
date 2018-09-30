namespace DesigningTestableApplications.Tip1.Good
{
    public class LoggerCloud : ILogger
    {
        public void LogMessage(string message)
        {
            //Log messsage here...
        }

        public string[] GetLast10Messages()
        {
            //Fetch messages from cloud...
            return new string[]
            {
                "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" 
            };
        }
    }
}
