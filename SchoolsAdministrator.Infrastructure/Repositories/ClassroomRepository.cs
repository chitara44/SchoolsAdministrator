using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Core.Interfaces.Repositories;
using SchoolsAdministrator.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Infrastructure.Repositories
{
    public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(AppDBContext context) : base(context)
        {

        }
    }
}