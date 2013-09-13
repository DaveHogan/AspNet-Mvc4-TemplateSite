using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ServiceLayer.Authentication
{
    public class AnonymousPrincipal : ICustomPrincipal
    {
        private IPrincipal principal;

        public AnonymousPrincipal(IPrincipal principal)
        {
            this.principal = principal;
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public System.Security.Principal.IIdentity Identity
        {
            get { return null; }
        }

        public bool IsInRole(string role)
        {
            return false;
        }
    }
}