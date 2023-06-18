using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taskManagerKidsAPI.Models;

public class Task
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Category { get; set; }
    [Required]
    [StringLength(50)]
    public string? Topic { get; set; }
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    [StringLength(100)]
    public string? Description { get; set; }
    [Required]
    [StringLength(50)]
    public string? Status { get; set; }
    [Required]
    [StringLength(50)]
    public string? Importance { get; set; }
    [Required]
    [Column(TypeName = "int")]
    public int GainScore { get; set; }
    public int KidId { get; set; }
    public Kid? Kid { get; set; }
}
