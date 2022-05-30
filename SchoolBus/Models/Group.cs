namespace SchoolBus.Models;

public partial class Group
{
    public Group()
    {
        Students = new HashSet<Student>();
    }

    public int Id { get; set; }
    public string Title { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
}
