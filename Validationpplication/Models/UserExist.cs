using System.ComponentModel.DataAnnotations;

namespace Validationpplication.Models
{
    public class UserExist : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var name = Convert.ToString(value);

            var d = Data.emails.Any(y => y.ToLower() == name.ToLower());

            return !d;
          
        }
    }
}
