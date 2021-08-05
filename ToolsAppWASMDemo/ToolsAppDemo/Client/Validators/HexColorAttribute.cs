using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ToolsAppDemo.Client.Validators
{
  public class HexColorAttribute: ValidationAttribute
  {
    private Regex _hexColorRegex;
    
    public HexColorAttribute(int hexColorLength)
    {
      _hexColorRegex = new Regex("^[0-9a-fA-F]{" + hexColorLength.ToString() + "}$");
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if (!_hexColorRegex.IsMatch(value.ToString()))
      {
        return new ValidationResult($"{validationContext.DisplayName} is not a valid hex color");
      }

      return ValidationResult.Success;
    }
  }
}
