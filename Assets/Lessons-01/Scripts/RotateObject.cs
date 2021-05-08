using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] RotateSettings _rotateSettings;
        private void Update()
        {
            transform.Rotate(Vector3.up, _rotateSettings.Speed*Time.deltaTime);
        }
    }
}
