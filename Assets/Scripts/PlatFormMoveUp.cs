using Unity.VisualScripting;
using UnityEngine;

public class PlatFormMoveUp : MonoBehaviour
{
    public float speed = 5f;
    public int index = 0;   
    public Transform[] points;
    void Start()
    {
        
    }
    private void FixedUpdate()
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(this.gameObject.transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
//beweegt het platform tussen 2 punten
/*maakt de player gelijk aan het platform zodat hij mee gaat met het platform.
 * zodra de player weg is staat de player 
 *     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            collision.transform.parent = null;
        }
    }
 */