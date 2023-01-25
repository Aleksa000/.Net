namespace USP.Models;
using System.ComponentModel.DataAnnotations;

public class UserModel : BaseModel
{
    //[StringLength(1000, ErrorMessage = "lose", MinimumLength = 1)] za odredjenu text area
    [Display(Name = "Username", Prompt = "Enter Username")]
    [Required(ErrorMessage = "Field User name must contain two numbers with name")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Field First name is required")]
    [Display(Name = "First name", Prompt = "Enter First name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Field Last name is required")]
    [Display(Name = "Last name", Prompt = "Enter Last name")]
    public string LastName { get; set; }
    [EmailAddress]//ubacivanje data anotacije anotacije generisemo pomocu []
    [Display(Name = "Email", Prompt = "Enter Email")]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter Password")]
    [Required(ErrorMessage = "Field password is required")]
    public string Password { get; set; }
    [Compare("Password")]
    [DataType(DataType.Password)]
    [Display(Name = "ComparePassword", Prompt = "Enter Compare Password")]
    public string ComparePassword { get; set; }
    //[Range(minimum:1950, maximum:2019)]
    
    
}