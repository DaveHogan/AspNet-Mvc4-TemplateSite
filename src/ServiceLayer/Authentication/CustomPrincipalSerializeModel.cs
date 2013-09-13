using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceLayer.Authentication
{
    // Idea taken from http://stackoverflow.com/a/10524305/235644
    public class CustomPrincipalSerializeModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}