using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestFront.HttpHelpers
{
    public interface IMyHttpMethods
    {
        Task<List<Customer>> GetRoomsAsync();
        Task<List<Customer>> GetCustomersAsync();
    }
}
