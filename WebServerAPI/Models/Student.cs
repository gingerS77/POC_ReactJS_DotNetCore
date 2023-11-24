namespace WebServerAPI.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
    }
}
