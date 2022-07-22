# SpringMath
Simple Unity package with implementation of spring physics.

Here is a sample class using spring to attract game object to the start position.

    public class SampleClass : MonoBehaviour {
        
        public Vector3Spring spring;

        private void Start() {
            spring.TargetPosition = transform.position;
        }

        private void Update() {
            spring.Position = transform.position;
            spring.Simulate(Time.deltaTime);
            transform.position = spring.Position;
        }
    }