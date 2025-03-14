using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public GameObject player;
    public Transform respawnpoint;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnpoint.position;
        }
    }
}
//sets the player location back to spawn/ checkpoint?