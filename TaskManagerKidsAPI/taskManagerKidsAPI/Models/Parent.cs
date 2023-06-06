using System.Collections.ObjectModel;

namespace taskManagerKidsAPI.Models;

public class Parent
{
    public Parent()
    {
        Kids = new Collection<Kid>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public ICollection<Kid>? Kids { get; set; }
}
