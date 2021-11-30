using System;

namespace WebApplication1.Services
{
    [ServiceVersion(Version = "V2", Type = typeof(ITesting))]
    public class TestingV2 : ITesting
    {
        public string ReverseName(string Name)
        {
            return Name.Insert(0, "Bla V2 ");
        }
    }
}
