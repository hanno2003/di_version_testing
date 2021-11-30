using System;

namespace ClassLibrary1
{
    [ServiceVersion()]
    public class TestingV2 : ITesting
    {
        public string ReverseName(string Name)
        {
            return Name.Insert(0, "Bla V2 ");
        }
    }
}
