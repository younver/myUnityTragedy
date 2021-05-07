using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Rotate Settings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 10f;
        public float Speed { get { return _speed; }}
    }
}

