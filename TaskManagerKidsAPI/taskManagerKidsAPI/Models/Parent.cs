using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace taskManagerKidsAPI.Models;

public class Parent
{
    public Parent()
    {
        Kids = new Collection<Kid>();
    }

    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }
    [Required]
    [StringLength(30)]
    public string? User { get; set; }
    [Required]
    [StringLength(30)]
    public string? Password { get; set; }
    public ICollection<Kid>? Kids { get; set; }
}
