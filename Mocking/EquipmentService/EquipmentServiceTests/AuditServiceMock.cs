using System;
using EquipmentService;

namespace EquipmentServiceTests
{
    public class AuditServiceMock : IAuditService
    {
        public bool WriteFunctionCalled { get; set; } = false;

        void IAuditService.WriteEmployeeInformation(Employee employee)
        {
            WriteFunctionCalled = true;
        }
    }
}

