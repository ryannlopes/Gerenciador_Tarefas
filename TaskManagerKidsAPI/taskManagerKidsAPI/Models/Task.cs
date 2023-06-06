namespace taskManagerKidsAPI.Models;

public class Task
{
    public int Id { get; set; }
    public string? Category { get; set; }
    public string? Topic { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Importance { get; set; }
    public int GainScore { get; set; }
    public int KidId { get; set; }
    public Kid? Kid { get; set; }
}
