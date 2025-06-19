using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int GroupId { get; set; }
        public string GroupName  { get; set; }
    }
    public class StudentCreateDto
    {
       
        public required string Name { get; set; }
        public int GroupId { get; set; }
       
    }
    public class StudentUpdateDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int GroupId { get; set; }
       
    }
}
