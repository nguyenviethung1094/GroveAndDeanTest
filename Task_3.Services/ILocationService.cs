using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_3.Services
{
    public interface ILocationService
    {
        Task<object> GetData(Dictionary<String, String> headers, Dictionary<String, String> pathVariables, Dictionary<String, String> parameters);
    }
}
