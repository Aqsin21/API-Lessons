using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Dtos
{
    public class GroupDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<int>? Students { get; set; }
    }

    public class GroupCreateDto
    {
        public string Name { get; set; }

    }

    public class GroupUpdateDto
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
