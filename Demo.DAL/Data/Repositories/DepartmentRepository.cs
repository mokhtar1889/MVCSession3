using Demo.DAL.Data.Contexts;
using Demo.DAL.Data.Models;

namespace Demo.DAL.Data.Repositories
{
    // primary constructor to apply dependancy injection
    internal class DepartmentRepository(ApplicationDbContext context)
    {

        // get Dapartment by id
        public Department? GetById(int id) {

            var department = context.Departments.Find(id);
            return department;
        }
    }
}
