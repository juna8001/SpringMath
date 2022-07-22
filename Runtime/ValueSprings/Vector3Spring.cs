using System;
using UnityEngine;

namespace SpringMath
{
    [Serializable]
    public class Vector3Spring : ValueSpring<Vector3>
    {
        protected override Vector3 Add(Vector3 a, Vector3 b) => a + b;

        protected override Vector3 Multiply(Vector3 a, float b) => a * b;

        protected override Vector3 Difference(Vector3 a, Vector3 b) => a - b;
    }
}