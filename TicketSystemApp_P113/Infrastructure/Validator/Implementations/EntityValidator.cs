using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp_P113.Core
{
    public class EntityValidator : IValidator
    {
        public IEnumerable<ValidationResult> Validate(object objecTToValidate)
        {
            ValidationContext c = new ValidationContext(objecTToValidate,null,null);
            List<ValidationResult> errorResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(objecTToValidate, c, errorResults, true))
            {
                return errorResults;
            }
            else
                return default(List<ValidationResult>);
        }
    }
}
