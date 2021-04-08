using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ParcelDelivery.Data;
using ParcelDelivery.Data.DataContracts.User;
using ParcelDelivery.Data.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Services.Impl
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext dbContext;
        public AccountService(ApplicationDbContext context)
        {
            this.dbContext = context;
        }
        public List<UserData> GetUsers()
        {
            var accountList = dbContext.Users.ToList();
            var roleList = dbContext.UserRoles.ToList();
            List<UserData> userDatas = new List<UserData>();
            foreach(var acc in accountList)
            {
                userDatas.Add(new UserData
                {
                    Id = acc.Id,
                    Name = acc.UserName,
                    Role = roleList.SingleOrDefault(x => x.UserId == acc.Id).role
                });
            }
            return userDatas;
        }
    }
}
