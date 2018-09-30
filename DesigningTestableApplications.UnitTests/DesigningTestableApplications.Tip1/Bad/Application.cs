using System.Collections.Generic;

namespace DesigningTestableApplications.Tip1.Bad
{
    public class Application
    {
        public IList<string> GetLast10LoggedMessages()
        {
            var logger = new Logger();

            return logger.GetLast10Messages();
        }

        public IList<string> GetLast10LoggedMessagesFromCloud()
        {
            var logger = new LoggerCloud();

            return logger.GetLast10Messages();
        }
    }
}
