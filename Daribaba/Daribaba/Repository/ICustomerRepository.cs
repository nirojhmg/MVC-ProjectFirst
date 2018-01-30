using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daribaba.Repository
{
   public interface ICustomerRepository
    {
       void Create(Customer customer);
       Customer SignIn(string customerName, string password);
    }
}
