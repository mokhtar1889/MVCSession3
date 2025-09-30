using Demo.BLL.DTOs;
using Demo.BLL.Factories;
using Demo.DAL.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL
{
    internal class DepartmentService(IDepartmentRepository departmentRepository)
    {

        //get all department
        public IEnumerable<DepartmentDto> GetAllDepartments() {

            var depts = departmentRepository.GetAll();

            var departmentsToReturn = depts.Select(d => d.ToDepartmentDto());

            return departmentsToReturn;
        
        }

        public DepartmentDetailsDto? GetById(int id) { 
        
            var dept = departmentRepository.GetById(id);

            return dept is null ? null : dept.ToDepartmentDetailsDto();
        
        }

        public int AddDepartment(CreatedDepartmentDto department) {

           return departmentRepository.Add(department.ToEntity()); 
        }

        public int UpdateDepartment(UpdateDepartmentDto departmentDto) { 
            
            return departmentRepository.Update(departmentDto.ToEntity());
        }

    }
}
