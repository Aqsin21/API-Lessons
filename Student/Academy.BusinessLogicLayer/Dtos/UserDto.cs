using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Dtos
{
    public class UserDto
    {
    }

    public class UserCreateDto
    {
        public required string FullName { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; } 
        public required string Password { get; set; } 
         
    }
}
