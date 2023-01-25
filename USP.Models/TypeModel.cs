using System.ComponentModel.DataAnnotations;

namespace USP.Models;


public class TypeModel : BaseModel
{
    [Required(ErrorMessage = "Type of motor is required")]
    [Display(Name = "Type of motor",Prompt = "Please enter type of motor")]
    public string? Type { get; set; }
   
 
}