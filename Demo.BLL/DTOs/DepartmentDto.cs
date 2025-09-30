﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs
{
    public class DepartmentDto
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; } 
        public DateOnly DateOfCreation { get; set; }
    }
}
