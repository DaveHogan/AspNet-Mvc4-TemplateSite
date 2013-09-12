using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.Validators;

namespace MvcApplication
{
    public static class MvcValidationExtension
    {
        public static void AddModelErrors(this ModelStateDictionary state, ValidationException ex)
        {
            foreach (var error in ex.Errors)
                state.AddModelError(error.Key, error.Message);
        }
    }
}