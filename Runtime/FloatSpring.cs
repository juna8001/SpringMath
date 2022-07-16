using System;

namespace SpringMath
{
    [Serializable]
    public class FloatSpring : ValueSpring<float>
    {
        protected override float Add(float a, float b) => a + b;

        protected override float Multiply(float a, float b) => a * b;

        protected override float Difference(float a, float b) => a - b;
    }
}