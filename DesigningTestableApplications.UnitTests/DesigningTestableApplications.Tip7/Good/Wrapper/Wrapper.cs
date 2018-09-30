using System;

namespace DesigningTestableApplications.Tip7.Good.Wrapper
{
    public class Wrapper : IWrapper
    {
        public string DoWork(string param1, int param2)
        {
            try
            {
                return ThirdPartyLibrary.ThirdPartyLibrary.DoWork(param1, param2).Result;
            }
            catch (Exception exception)
            {
                throw new Exception("The Third-Party Library has thrown an exception.", exception);
            }
        }
    }
}
