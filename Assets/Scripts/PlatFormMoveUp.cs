using Unity.VisualScripting;
using UnityEngine;

public class PlatFormMoveUp : MonoBehaviour
{
    public float speed = 5f;
    public int index = 0;   
    public Transform[] points;
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[index].position,speed * Time.deltaTime);
        //moves the platform in the direction of the set points in unity
        if(Vector2.Distance(transform.position, points[index].position) <.1f)
        { // if the platform is at the point in unity it sets the point array 1 up causing it to move to the next point
            index++;
        }
        if(index >= points.Length)
        { // resets the points array causing it to go back to the first point and starting over
            index = 0;  
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(this.gameObject.transform);
    }
    //makes the player object a child of the movingplatform making movement on the platform smooth.
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}

