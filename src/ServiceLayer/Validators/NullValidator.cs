using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    sealed class NullValidator<T> : Validator<T>
    {
        protected override IEnumerable<ValidationResult> Validate(T entity)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
