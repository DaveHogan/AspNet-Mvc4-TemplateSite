using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    public interface IValidator
    {
        IEnumerable<ValidationResult> Validate(object entity);
    }
}
