namespace Academy.BusinessLogicLayer.Dtos
{
    public class GroupDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<int>? Students { get; set; }
        public List<int>? Teachers { get; set; }
    }

    public class GroupCreateDto
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public TeacherDto  Teacher {  get; set; }
    }

    public class GroupUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Teachers   { get; set; }




    }


}
