using System.Collections.Generic;

namespace WebApplication1.Services
{
    public interface IValuesService
    {
        IEnumerable<string> FindAll();

        string Find(int id);
    }
}