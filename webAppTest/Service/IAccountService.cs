using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Auth;

namespace ParcelDelivery.Service
{
    interface IAccountService
    {
        User GetUser(string name);
        bool DeleteUser(int id);
        bool EditUser(int id);
    }
}
