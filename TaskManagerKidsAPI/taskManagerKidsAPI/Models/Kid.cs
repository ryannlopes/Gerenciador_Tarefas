using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taskManagerKidsAPI.Models;

public class Kid
{
    public Kid()
    {
        Parents = new Collection<Parent>();
        Tasks = new Collection<Task>();
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
    [Required]
    [Column(TypeName = "int")]
    public int Score { get; set; }
    public ICollection<Parent>? Parents { get; set; }
    public ICollection<Task>? Tasks { get; set; }
}
