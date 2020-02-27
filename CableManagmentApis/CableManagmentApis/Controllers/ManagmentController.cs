using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CableManagmentApis.Models;

namespace CableManagmentApis.Controllers
{
    public class ManagmentController : ApiController
    {
        public IHttpActionResult GetAllRoles()
        {
            IList<Roles> roles = null;
            using (var cmd=new CableMagementEntities())
            {
                roles = cmd.User_Roles.Select(s=>new Roles() {
                    Role_id=s.Role_Id,
                    Role_Code=s.Role_Code,
                    Role_Desc=s.Role_Desc
                }).ToList<Roles>();
            }
            if (roles.Count==0)
            {
                return NotFound();
            }
            return Ok(roles);
        }
    }
}
