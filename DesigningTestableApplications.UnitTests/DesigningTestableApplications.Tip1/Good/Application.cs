using System.Collections.Generic;

namespace DesigningTestableApplications.Tip1.Good
{
    public class Application
    {
        private readonly ILogger logger;

        public Application()
        {
            this.logger = new Logger();
        }

        public IList<string> GetLast10LoggedMessages()
        {
            return logger.GetLast10Messages();
        }
    }
}
