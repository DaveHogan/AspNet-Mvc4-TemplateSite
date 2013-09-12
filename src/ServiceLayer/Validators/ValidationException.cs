using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    // Principle taken from http://stackoverflow.com/a/4851953/235644
    public class ValidationException : Exception
    {
        public ValidationException(IEnumerable<ValidationResult> r)
            : base(GetFirstErrorMessage(r))
        {
            this.Errors = new ReadOnlyCollection<ValidationResult>(r.ToArray());
        }

        public ReadOnlyCollection<ValidationResult> Errors { get; private set; }

        private static string GetFirstErrorMessage(
            IEnumerable<ValidationResult> errors)
        {
            return errors.First().Message;
        }
    }    
}
