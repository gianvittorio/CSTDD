using System;
namespace EquipmentService
{
    public class AuditService : IAuditService
    {
        public string Path = "auditlog.txt";

        void IAuditService.WriteEmployeeInformation(Employee employee)
        {
            using (StreamWriter writer = File.AppendText(Path))
            {
                writer.WriteLine($"Employ {employee.EmployeeId} has a bundle with {employee.Bundle}");
            }
        }
    }
}

