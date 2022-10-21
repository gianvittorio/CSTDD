using System;
namespace EquipmentService
{
    public interface IEquipmentBundleFactory
    {
        EquipmentBundle CreateStandardBundle();
    }
}

