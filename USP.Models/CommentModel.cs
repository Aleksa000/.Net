#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace USP.Models;

public class CommentModel : BaseModel
{ 
    [Required(ErrorMessage = "Category is required")]
    [Display(Name = "The category of car", Prompt = "The category of car")]
    public string Category { get; set; }
    [Required(ErrorMessage = "The type of motor is required")]
    [Display(Name = "The type of motor", Prompt = "The type ofo motor")]

    public string Type { get; set; }

    [Required(ErrorMessage = "Car name is required")]
    [Display(Name = "The name of car", Prompt = "The name of car")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Comment is required"),StringLength(100),MinLength(4)]
    [Display(Name = "Comment for on car parts", Prompt = "Please comment")]
    public string Review { get; set; }

    public List<SelectListItem> Types { get; set; }

    public List<SelectListItem> Categories { get; set; }
}