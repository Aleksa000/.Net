using System.ComponentModel.DataAnnotations;

namespace USP.Models;


public class CategoryModel : BaseModel
{
    [Required(ErrorMessage = "Name of product is required")]
    [Display(Name = "Name of product",Prompt = "Please enter name of product")]
    public string? Name { get; set; }
   
 
}