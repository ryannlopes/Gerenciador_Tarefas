using System.Collections.ObjectModel;

namespace taskManagerKidsAPI.Models;

public class Kid
{
    public Kid()
    {
        Parents = new Collection<Parent>();
        Tasks = new Collection<Task>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public int Score { get; set; }
    public ICollection<Parent>? Parents { get; set; }
    public ICollection<Task>? Tasks { get; set; }
}
