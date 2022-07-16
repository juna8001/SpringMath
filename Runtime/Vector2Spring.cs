using System;
using UnityEngine;

namespace SpringMath
{
    [Serializable]
    public class Vector2Spring : ValueSpring<Vector2>
    {
        protected override Vector2 Add(Vector2 a, Vector2 b) => a + b;

        protected override Vector2 Multiply(Vector2 a, float b) => a * b;

        protected override Vector2 Difference(Vector2 a, Vector2 b) => a - b;
    }
}