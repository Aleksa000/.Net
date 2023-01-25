#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace USP.Models;

public class WorkModel : BaseModel
{ 
    
    [Required(ErrorMessage = "Filed is required"),StringLength(100),MinLength(4)]
    [Display(Name = "Comment about us how work", Prompt = "Please comment")]
    public string? Name { get; set; }
    
}