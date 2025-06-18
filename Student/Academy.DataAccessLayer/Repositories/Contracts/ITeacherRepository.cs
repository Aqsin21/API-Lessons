using Academy.DataAccessLayer.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccessLayer.Repositories.Contracts
{
    public interface ITeacherRepository :IRepositoryAsync<Teacher>
    {
    }
}
