using UnityEngine;

public class PlatFormMoveUp : MonoBehaviour
{
    public float speed = 5f;
    public int index = 0;   
    public Transform[] points;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[index].position,speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, points[index].position) <.1f)
        {
            index++;
        }
        if(index >= points.Length)
        {
            index = 0;  
        }
    }
}
//beweegt het platform tussen 2 punten