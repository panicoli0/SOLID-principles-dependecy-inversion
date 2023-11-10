
namespace SOLID.DependencyInversion
{
    internal interface IShipInput
    {
        void ReadInput();
        float Thrust { get; }
        float Rotation { get; }
        
    }
}