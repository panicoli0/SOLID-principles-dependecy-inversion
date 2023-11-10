using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private ShipSettings shipSettings;

        private IShipInput shipInput;
        private ShipMotor shipMotor;

        private void Awake()
        {
            shipInput = shipSettings.UseAi ? new AiInput() : new ControllerInput();
            shipMotor = new ShipMotor(shipInput, transform, shipSettings);
        }

        private void Update()
        {
            shipInput.ReadInput();
            shipMotor.Tick();
        }
    }
}
