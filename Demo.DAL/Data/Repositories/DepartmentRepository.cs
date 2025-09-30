using Demo.DAL.Data.Contexts;
using Demo.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

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

        //get all departments
        public IEnumerable<Department> GetAll(bool withTracking = false) {

            if (withTracking == true) return context.Departments.ToList();

            else return context.Departments.AsNoTracking().ToList();
            
        
        }

        // add Department
        public int Add(Department department) { 
            
            context.Departments.Add(department); 
            return context.SaveChanges();
            
        }

        public int Update(Department department)
        {

            context.Departments.Update(department);
            return context.SaveChanges();

        }

        public int Remove(Department department)
        {

            context.Departments.Update(department);
            return context.SaveChanges();

        }
    }
}
