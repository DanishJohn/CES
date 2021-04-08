using Microsoft.AspNetCore.Identity;
using ParcelDelivery.Data.DataContracts.User;
using ParcelDelivery.Data.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Services
{
    public interface IAccountService
    {
        List<UserData> GetUsers();
    }
}
