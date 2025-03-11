using Unity.VisualScripting;
using UnityEngine;

public class CamerScript : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;

    public Transform target;

    private Vector3 vel = Vector3.one;

    private void Update()
    {
        Vector3 targetposition = target.position + offset;
        targetposition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref vel,damping);
    }

}
