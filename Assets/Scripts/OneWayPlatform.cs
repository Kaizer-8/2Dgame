using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private GameObject Player;
    public bool isUp;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    { // als de input s is en van het movement script de player op de grond dan wordt de collider van het platform uit gezet.
        if (Input.GetKeyDown(KeyCode.S) && Player.GetComponent<Movement>().IsGrounded())
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
