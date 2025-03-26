using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private GameObject player;
    public bool isUp;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    { // als de input s is en van het movement script de player op de grond dan wordt de collider van het platform uit gezet.
        if (Input.GetKeyDown(KeyCode.S) && player.GetComponent<Movement>().isGrounded)
        {
            transform.parent.GetComponent<Collider2D>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.parent.GetComponent<BoxCollider2D>().enabled = isUp;
        }
    }
}
