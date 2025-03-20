using UnityEngine;
using UnityEngine.SceneManagement;
public class FinshLine : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
    }
    private void OnCollisionStay2D(Collision2D collision)
    { 
    if (Input.GetKey(KeyCode.K))
        {
             SceneManager.LoadScene(1);
        }
    }
}
// constantly checks if the player location is equal to the object the scipt is attatched to.
//if the object is == to the player gives the option to go to the next level by pressing an input