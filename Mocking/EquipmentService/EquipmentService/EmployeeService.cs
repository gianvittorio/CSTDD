using System;
namespace EquipmentService
{
    public class EmployeeService : IEmployeeService
    {
        Employee IEmployeeService.Connect(Guid employGuid, EquipmentBundle bundle)
        {
            return new Employee()
            {
                EmployeeId = employGuid,
                Bundle = bundle
            };
        }
    }
}

