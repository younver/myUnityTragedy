using UnityEngine;

namespace Lessons
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private float _speed = 10f;

        private void Update()
        {
            transform.Rotate(Vector3.up, _speed*Time.deltaTime);
        }
    }
}
