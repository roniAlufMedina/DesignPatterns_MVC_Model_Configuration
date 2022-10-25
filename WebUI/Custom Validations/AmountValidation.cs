using System.ComponentModel.DataAnnotations;

namespace WebUI.Custom_Validations
{
    public class AmountValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Tutar boş bırakılamaz");
            if (!(value is int)) //tam sayı değilse
                return new ValidationResult("Girilen veri tam sayı değil.");
            int tutar = (int)value;
            if (tutar <= 0)
                return new ValidationResult("Sıfırdan büyük bir değer girmeniz gerek.");
            return null;
        }
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;
            if (!(value is int))
                return false;
            int tutar = (int)value;
            if (tutar <= 0)
               return false;
            return true;
        }
    }
}
