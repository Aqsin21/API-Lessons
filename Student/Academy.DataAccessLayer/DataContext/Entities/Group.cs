namespace Academy.DataAccessLayer.DataContext.Entities
{
    public class Group :BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; } = [];

        public List<int> TeacherId { get; set; }
    }
}
