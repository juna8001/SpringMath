using UnityEngine;

namespace SpringMath
{
    public abstract class SpringBehaviour<ST> : MonoBehaviour where ST : BaseSpring
    {
        public SpringSimulationMode simulationMode;
        [SerializeField]
        private ST _spring;

        public ST Spring => _spring;

        public void Simulate(float deltaTime) => _spring.Simulate(deltaTime);

        private void Update()
        {
            if (simulationMode == SpringSimulationMode.Update)
            {
                Simulate(Time.deltaTime);
            }
        }

        private void FixedUpdate()
        {
            if (simulationMode == SpringSimulationMode.FixedUpdate)
            {
                Simulate(Time.fixedTime);
            }
        }
    }

    public enum SpringSimulationMode
    {
        Manual,
        Update,
        FixedUpdate
    }
}