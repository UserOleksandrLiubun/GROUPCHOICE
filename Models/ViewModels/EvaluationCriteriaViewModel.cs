using System.ComponentModel.DataAnnotations;

public class EvaluationCriteriaViewModel
{
    public int SettingsId { get; set; }
    public int DBVoteAlternativeId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    [Range(0, 100)]
    public double? ImportanceValue { get; set; }

    public double MinValue { get; set; }
    public double MaxValue { get; set; }
    public double StepValue { get; set; }
    [Range(0, double.MaxValue)]
    [Display(Name = "Значення")]
    public double Value { get; set; }
}