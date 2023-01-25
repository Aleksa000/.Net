using System.ComponentModel.DataAnnotations;

namespace USP.Models;

public class LoginModel
{
    [EmailAddress]//ubacivanje data anotacije anotacije generisemo pomocu []
    [Display(Name = "Email", Prompt = "Enter Email")]
    public string Email { get; set; }
    
    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter Password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    
    public string ReturnUrl { get; set; }
}