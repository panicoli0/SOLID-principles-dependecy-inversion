using Random = UnityEngine.Random;

namespace SOLID.DependencyInversion
{
    internal class AiInput : IShipInput
    {
        public float Thrust { get; private set; }

        public float Rotation { get; private set; }

        public void ReadInput()
        {
            Rotation = Random.Range(-1f, 1f);
            Thrust = Random.Range(0f, 1f);
        }
    }
}