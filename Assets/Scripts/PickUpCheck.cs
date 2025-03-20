using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class PickUpCheck : MonoBehaviour
{
    bool ColliderCheck = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            if (!ColliderCheck)
            { // checks if the player collids with the object and from the movement script grabs the jump variable and sets it to setjumpingpower
                collision.gameObject.GetComponent<Movement>().SetJumpingPower();
                Destroy(gameObject);
            }
        }
        ColliderCheck = true;
    }
}
