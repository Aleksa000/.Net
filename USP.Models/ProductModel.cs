#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace USP.Models;

public class ProductModel : BaseModel
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

    [Required(ErrorMessage = "Year of the car is required")]
    [Display(Name = "The year of the car", Prompt = "The year of the car")]
    [Range(minimum:2000, maximum:2022)]
    public int? Year { get; set; }

    public List<SelectListItem> Types { get; set; }

    public List<SelectListItem> Categories { get; set; }
}