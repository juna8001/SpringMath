
using UnityEngine;

namespace SpringMath
{
    public class TransformSpringBehaviour : SpringBehaviour<TransformSpring>
    {
        protected void Awake()
        {
            if (Spring.Transform == null)
            {
                Spring.Transform = transform;
            }
        }
    }
}