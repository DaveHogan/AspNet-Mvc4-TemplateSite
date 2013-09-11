using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MvcApplication
{
    public interface ICustomPrincipal : IPrincipal
{
    int UserId { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}
}