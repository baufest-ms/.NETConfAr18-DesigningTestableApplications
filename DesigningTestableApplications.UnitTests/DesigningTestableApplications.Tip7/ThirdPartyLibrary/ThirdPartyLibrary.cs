namespace DesigningTestableApplications.Tip7.ThirdPartyLibrary
{
    public static class ThirdPartyLibrary
    {
        public static ThirdPartyLibraryResult DoWork(string param1, int param2)
        {
            return new ThirdPartyLibraryResult { Result = param1 + param2 };
        }
    }
}
