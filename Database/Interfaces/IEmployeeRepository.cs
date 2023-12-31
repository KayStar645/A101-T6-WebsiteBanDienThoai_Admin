﻿using Domain.Entities;

namespace Database.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<Employee> FindByInternalCodesync(string pInternalCode);
    }
}
