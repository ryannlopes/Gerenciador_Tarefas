using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace taskManagerKidsAPI.Models;

public class Reward
{
    [JsonIgnore]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Title { get; set; }
    [Required]
    [StringLength(100)]
    public string? Description { get; set; }
    [Required]
    [Column(TypeName = "int")]
    public int Score { get; set; }
}