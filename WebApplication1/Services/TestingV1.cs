using System;

namespace WebApplication1.Services
{
    [ServiceVersion(Version = "V1", Type = typeof(ITesting))]
    public class TestingV1 : ITesting
    {
        public string ReverseName(string Name)
        {
            return Name.Insert(0, "Bla V1 ");
        }
    }
}
