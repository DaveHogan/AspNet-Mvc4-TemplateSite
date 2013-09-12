using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Validators
{
    public class ValidationResult
    {
        public ValidationResult(string key, string message) 
        { 
        }

        public string Key { get; private set; }
        public string Message { get; private set; }
    }
}
