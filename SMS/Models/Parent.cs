namespace SMS.Models
{
    public enum Title
    {
        Mr,
        Mrs,
        Miss,
        Dr
    }

    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
