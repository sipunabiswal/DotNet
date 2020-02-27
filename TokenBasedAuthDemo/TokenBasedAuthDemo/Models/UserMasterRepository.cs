using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenBasedAuthDemo.Models
{
    public class UserMasterRepository : IDisposable
    {
        CableMagementEntities context = new CableMagementEntities();
        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMasters.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}