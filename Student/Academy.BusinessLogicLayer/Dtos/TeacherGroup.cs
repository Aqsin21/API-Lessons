using Academy.DataAccessLayer.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Dtos
{
    public class TeacherGroupDto
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }


    }

    public class TeacherGroupCreateDto
    {
        public int TeacherId { get; set; }
        public int GroupId { get; set; }

    }
    public class TeacherGroupUpdateDto
    {
        public int TeacherId { get;set; }
        public int GroupId { get; set; }
    }

}
