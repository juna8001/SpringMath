using System;
using UnityEngine;

namespace SpringMath
{
    [Serializable]
    public class TransformSpring : BaseSpring<Vector3>
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private bool _useWorldPosition;
        [SerializeField] private bool _useTargetTransform;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Vector3 _targetPosition;
        [SerializeField] private Vector3 _velocity;

        public Transform Transform
        {
            get => _transform;
            set => _transform = value;
        }

        private Vector3 TargetTransformPosition
        {
            get => UseWorldPosition ? _targetTransform.position : _targetTransform.localPosition;
            set
            {
                if (UseWorldPosition)
                    _targetTransform.position = value;
                else
                    _targetTransform.localPosition = value;
            }
        }
        
        public override Vector3 TargetPosition
        {
            get => _useTargetTransform ? _targetPosition = TargetTransformPosition : _targetPosition;
            set
            {
                _targetPosition = value;
                if (_useTargetTransform)
                {
                    TargetTransformPosition = _targetPosition;
                }
            }
        }

        public override Vector3 Position
        {
            get => UseWorldPosition ? _transform.position : _transform.localPosition;
            set
            {
                if (UseWorldPosition)
                    _transform.position = value;
                else
                    _transform.localPosition = value;
            }
        }

        public override Vector3 Velocity
        {
            get => _velocity;
            set => _velocity = value;
        }

        public bool UseWorldPosition
        {
            get => _useWorldPosition;
            set => _useWorldPosition = value;
        }

        public bool UseTargetTransform
        {
            get => _useTargetTransform;
            set => _useTargetTransform = value;
        }

        public Transform TargetTransform
        {
            get => _targetTransform;
            set => _targetTransform = value;
        }

        protected override Vector3 Add(Vector3 a, Vector3 b) => a + b;

        protected override Vector3 Multiply(Vector3 a, float b) => a * b;

        protected override Vector3 Difference(Vector3 a, Vector3 b) => a - b;
    }
}