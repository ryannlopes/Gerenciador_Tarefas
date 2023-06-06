namespace taskManagerKidsAPI.Models;

public class Parent_Kid
{
    public int Id { get; set; }
    public int KidId { get; set; }
    public Kid? Kid { get; set; }
    public int ParentId { get; set; }
    public Parent? Parent { get; set; }
}
