using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MVCClininca.Validators
{
    public class CheckValidMatriculaAtributte : ValidationAttribute
    {
        public CheckValidMatriculaAtributte() 
        { 
            ErrorMessage= "La matricula esta comprendida de dos letras Mayusculas y 4 numeros Ej. : AA1111";
        }
        public override bool IsValid(object value)
        {
            string matricula = (string)value;
            
            if (Regex.IsMatch(matricula, "^[A-Z]{2}[0-9]{4}")) return true; else return false; 
        }
    }
}
