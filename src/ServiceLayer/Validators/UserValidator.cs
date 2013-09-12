using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    public sealed class UserValidator : Validator<Models.User>
    {
        protected override IEnumerable<ValidationResult> Validate(Models.User entity)
        {
            if (entity.FirstName.Trim().Length == 0)
                yield return new ValidationResult("FirstName",
                    "FirstName is required.");

            if (entity.LastName.Trim().Length == 0)
                yield return new ValidationResult("LastName",
                    "LastName is required.");

            if (entity.Email.Trim().Length == 0)
                yield return new ValidationResult("Email",
                    "Email is required.");
        }
    }
}
