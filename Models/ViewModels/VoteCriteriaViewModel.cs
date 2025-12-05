using System.ComponentModel.DataAnnotations;

public class VoteCriteriaViewModel
{
    [Required(ErrorMessage = SharedResource.RequireMessage)]
    [Display(Name = "Назва")]
    public string Title { get; set; }
    [Display(Name = "Опис")]
    public string Description { get; set; }

    [Range(1, 100)]
    [Display(Name = "Важливість")]
    public double? Importance { get; set; }
    [Display(Name = "Мінімальне значення")]
    public double MinValue { get; set; } = 0;
    [Display(Name = "Крок")]
    public double StepValue { get; set; } = 0;
    [Display(Name = "Максимальне значення")]
    public double MaxValue { get; set; } = 10;
}