using UnityEngine;
using UnityEngine.SceneManagement;
public class FinshLine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //comparing the 2 tags of the player and finishline and thn 
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
    if (Input.GetKey(KeyCode.K))
        {
             SceneManager.LoadScene(1);
        }
    }
}
//checkt of de player op de finishline staat en als de player input 1 is gegeven set the player location and spawnpoint to the next lvl
