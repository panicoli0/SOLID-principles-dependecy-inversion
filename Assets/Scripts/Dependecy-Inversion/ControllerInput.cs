using UnityEngine;

namespace SOLID.DependencyInversion
{
    internal class ControllerInput : IShipInput
    {
        public void ReadInput()
        {
            Rotation = Input.GetAxis("Horizontal");
            Thrust = Input.GetAxis("Vertical");
        }

        public float Thrust { get; private set; }
        public float Rotation { get; private set; }
    }
}