using System.ComponentModel.DataAnnotations;

public class VoteEvaluationViewModel
{
    public int VoteId { get; set; }
    [Display(Name = "Назва")]
    public string VoteTitle { get; set; }
    [Display(Name = "Опис")]
    public string Description { get; set; }
    [Display(Name = "Приватне")]
    public bool IsPrivate { get; set; }
    public List<DBVoteAlternative> Alternatives { get; set; } = new();
    public List<EvaluationCriteriaViewModel> Criteria { get; set; } = new();
    [Display(Name = "Позиції альтернатив")]
    public Dictionary<int, int> AlternativePositions { get; set; } = new Dictionary<int, int>();
}