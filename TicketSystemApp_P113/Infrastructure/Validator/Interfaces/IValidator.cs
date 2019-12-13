using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSystemApp_P113.Core
{
    public interface IValidator
    {
        IEnumerable<ValidationResult> Validate(object objecTToValidate);
    }
}