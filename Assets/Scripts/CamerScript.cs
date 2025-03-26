using Unity.VisualScripting;
using UnityEngine;

public class CamerScript : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    //maakt een veld in unit om de waarden te veranderen
    public Transform target;

    private Vector3 vel = Vector3.one;

    private void Update()
    { // sets the camera to targetposition wich is the player.
        Vector3 targetposition = target.position + offset;
        targetposition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref vel,damping);
        //de positie van het gameobject staat gelijk aan de vector 3 wat de 3 waarden zijn om positie te vertellen x,y,z.
    }

}
