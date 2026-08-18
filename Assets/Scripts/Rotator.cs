using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed;
    
      void FixedUpdate()
    {
        transform.Rotate(rotationSpeed * Time.fixedDeltaTime);
    }
}
