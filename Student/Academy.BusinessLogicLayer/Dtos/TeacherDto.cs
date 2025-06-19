using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Dtos
{
    public  class TeacherDto
    {
        public int Id { get; set; }
        public  required string Name { get; set; }

        public List<int>? Groups { get; set; }
    }


    public class TeacherCreateDto
    {
        public required string Name { get; set; }
        public List<int?> Groups { get; set; }
    }


    public class TeacherUpdateDto 
    { 
        public required string Name { get; set; }
        public List<int?> Groups { get; set; }
    }
}
