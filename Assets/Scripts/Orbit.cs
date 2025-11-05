using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] Transform pivot;
    [SerializeField] float angularSpeed = 20f;
    [SerializeField] float selfRotationSpeed = 30f;

    void Update()
    {
        if (pivot != null)
            transform.RotateAround(pivot.position, Vector3.up, angularSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime, Space.Self);
    }
}
