using Xunit;
using EquipmentService;
using Moq;

namespace EquipmentServiceTests
{
    public class EquipmentServiceTests
    {
        [Fact]
        public void AssignStandardBundleToEmployee_EmployeeId_ReturnsCorrectEmployee()
        {
            var employeeId = new Guid();

            var testItem = new EquipmentItem()
            {
                Name = "Test"
            };
            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            var bundleFactoryMock = new Mock<IEquipmentBundleFactory>();
            bundleFactoryMock.Setup(x => x.CreateStandardBundle()).Returns(testBundle);

            var testEmployee = new Employee()
            {
                EmployeeId = employeeId,
                Bundle = testBundle
            };

            var employeeServiceMock = new Mock<IEmployeeService>();
            employeeServiceMock.Setup(x => x.Connect(It.Is<Guid>(y => y == employeeId), It.IsAny<EquipmentBundle>()))
                .Returns(testEmployee);

            var auditServiceMock = new Mock<IAuditService>();

            var service = new EquipmentService.EquipmentService(bundleFactoryMock.Object, employeeServiceMock.Object, auditServiceMock.Object);
            var result = service.AssignStandardBundleToEmployee(employeeId);

            Assert.Equal(employeeId, result.EmployeeId);
            Assert.Single(result.Bundle.Items);
            auditServiceMock.Verify(x => x.WriteEmployeeInformation(It.Is<Employee>(y => y == testEmployee)));
        }
    }
}
