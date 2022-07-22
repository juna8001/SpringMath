using UnityEngine;

namespace SpringMath
{
    public abstract class ValueSpring<T> : BaseSpring<T>
    {
        [SerializeField] private T _targetPosition;
        [SerializeField] private T _position;
        [SerializeField] private T _velocity;

        public override T TargetPosition
        {
            get => _targetPosition;
            set => _targetPosition = value;
        }

        public override T Position
        {
            get => _position;
            set => _position = value;
        }

        public override T Velocity
        {
            get => _velocity;
            set => _velocity = value;
        }
    }
}