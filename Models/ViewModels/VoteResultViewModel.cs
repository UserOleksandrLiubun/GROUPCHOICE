public class VoteResultViewModel
{
    public string Title { get; set; }
    public bool IsPrivate { get; set; }
    public DBVote DBVote { get; set; }
    public List<string> UserIDs { get; set; }
    public List<DBVoteItemSettings> DBVoteItemSettings { get; set; }
    public List<DBVoteItem> DBVoteItem { get; set; }
    public List<DBVoteAlternative> DBVoteAlternative { get; set; }
}