using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    public abstract class Validator<T> : IValidator
    {
        IEnumerable<ValidationResult> IValidator.Validate(object entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            return this.Validate((T)entity);
        }

        protected abstract IEnumerable<ValidationResult> Validate(T entity);
    }
}
