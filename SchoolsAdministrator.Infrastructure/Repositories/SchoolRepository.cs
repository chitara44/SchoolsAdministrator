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
    public class SchoolRepository : BaseRepository<School>, ISchoolRepository
    {
        public SchoolRepository(AppDBContext context) : base(context)
        {

        }
    }
}