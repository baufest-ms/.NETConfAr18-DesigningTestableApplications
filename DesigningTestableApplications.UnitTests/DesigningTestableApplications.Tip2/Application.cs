using System.Collections.Generic;

namespace DesigningTestableApplications.Tip2
{
    public class Application
    {
        private readonly ILogger logger;

        public Application(ILogger logger)
        {
            this.logger = logger;
        }

        public IList<string> GetLast10LoggedMessages()
        {
            return logger.GetLast10Messages();
        }
    }
}
