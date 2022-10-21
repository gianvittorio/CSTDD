using System;
using EquipmentService;

namespace EquipmentServiceTests
{
    public class EmployeeServiceMock : IEmployeeService
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

