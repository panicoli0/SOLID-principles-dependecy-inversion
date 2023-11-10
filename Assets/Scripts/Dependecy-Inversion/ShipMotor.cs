using UnityEngine;

namespace SOLID.DependencyInversion
{
    internal class ShipMotor
    {
        private readonly IShipInput shipInput;
        private readonly Transform transformToMove;
        private readonly ShipSettings shipSettings;

        public ShipMotor(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings)
        {
            this.shipInput = shipInput;
            this.transformToMove = transformToMove;
            this.shipSettings = shipSettings;
        }

        internal void Tick()
        {
            transformToMove.Rotate(shipInput.Rotation * shipSettings.TurnSpeed * Time.deltaTime * Vector3.up);
            transformToMove.position += shipInput.Thrust * shipSettings.TurnSpeed * Time.deltaTime * transformToMove.forward;
        }
    }
}