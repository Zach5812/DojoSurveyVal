using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models;
public class Student
{
    [Required(ErrorMessage ="Name is required")]
    [MinLength(2)]
    public string Name {get; set;}

    [Required(ErrorMessage ="Location is required")]
    public string Location {get; set;}
    [Required(ErrorMessage ="Language is required")]
    public string Language {get; set;}
    
    [MinLength(20, ErrorMessage ="Comment must be at least 20 characters")]
    public string? Comment {get; set;}
}
