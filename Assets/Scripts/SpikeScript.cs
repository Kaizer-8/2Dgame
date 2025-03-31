using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public GameObject player;
    public Transform respawnpoint;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    { // checks if the player collids with the spikes and sets the player to the respawnpoint.
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnpoint.position;
        }
    }
}
//sets the player location back to spawn/ checkpoint?