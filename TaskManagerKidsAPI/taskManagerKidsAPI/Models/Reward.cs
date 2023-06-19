using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taskManagerKidsAPI.Models;

public class Reward
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    [StringLength(100)]
    public string? Description { get; set; }
    public int TaskId { get; set; }
    public Task? Task { get; set; }
}