using SchoolsAdministrator.Core.Interfaces;
using SchoolsAdministrator.Core.Interfaces.Repositories;
using SchoolsAdministrator.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        private SchoolRepository _schoolRepository;
        private ClassroomRepository _classroomRepository;

        public UnitOfWork(AppDBContext context)
        {
            this._context = context;
        }

        public ISchoolRepository SchoolRepository => _schoolRepository ??= new SchoolRepository(_context);

        public IClassroomRepository ClassroomRepository => _classroomRepository ??= new ClassroomRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
