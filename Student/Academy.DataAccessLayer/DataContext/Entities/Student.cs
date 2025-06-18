namespace Academy.DataAccessLayer.DataContext.Entities
{
    public class Student :BaseEntity
    {
        public required string Name { get; set; }
        public int GroupId { get; set; }
        public  virtual Group? Group { get; set; }  

        

       
    }
}
