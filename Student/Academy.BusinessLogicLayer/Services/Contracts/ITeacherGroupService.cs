﻿using Academy.BusinessLogicLayer.Dtos;
using Academy.DataAccessLayer.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.BusinessLogicLayer.Services.Contracts
{
    public interface ITeacherGroupService :ICrudService<TeacherGroupDto ,TeacherGroupCreateDto , TeacherGroupUpdateDto ,TeacherGroup>
    {
    }
}
