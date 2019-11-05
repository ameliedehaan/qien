using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.Validations
{
    public class validate_stock: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var IsValid = false;
            var x = Convert.ToInt32(value);
            if (x % 2 == 0)
            {
                IsValid = true;
            }
            return IsValid;
        }
    }
}