using System;
using EquipmentService;

namespace EquipmentServiceTests
{
    public class EquipmentBundleFactoryMock : IEquipmentBundleFactory
    {
        EquipmentBundle IEquipmentBundleFactory.CreateStandardBundle()
        {
            var testItem = new EquipmentItem()
            {
                Name = "Test"
            };

            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            return testBundle;
        }
    }
}

