using System;

namespace ClassLibrary1
{
    public class TestingV1 : ITesting
    {
        public string ReverseName(string Name)
        {
            return Name.Insert(0, "Bla V1 ");
        }
    }
}
