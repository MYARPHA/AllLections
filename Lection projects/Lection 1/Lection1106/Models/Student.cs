namespace Lection1106.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }

        public virtual Group Group { get; set; } = null!;
    }
}
