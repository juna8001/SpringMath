using UnityEngine;

namespace SpringMath
{
    public abstract class BaseSpring<T>
    {
        public float stiffness = 1f;
        public float strength = 10f;
        public float dumping = .5f;
        public float stepSize = 0.0078125f;

        public abstract T TargetPosition { get; set; }
        public abstract T Position { get; set; }
        public abstract T Velocity { get; set; }

        public void Simulate(float deltaTime)
        {
            var stepCount = Mathf.CeilToInt(deltaTime / stepSize);
            var stepDeltaTime = deltaTime / stepCount;

            for (int i = 0; i < stepCount; i++)
            {
                var strengthForce = Multiply(Difference(Position, TargetPosition), strength);
                var dumpingForce = Multiply(Velocity, dumping);
                var force = Add(strengthForce, dumpingForce);
                ChangeVelocity(Multiply(force, -stiffness * stepDeltaTime));
                ChangePosition(Multiply(Velocity, stepDeltaTime));
            }
        }

        protected abstract T Add(T a, T b);
        protected abstract T Multiply(T a, float b);
        protected abstract T Difference(T a, T b);

        protected abstract void ChangeVelocity(T delta);
        protected abstract void ChangePosition(T delta);
    }
}