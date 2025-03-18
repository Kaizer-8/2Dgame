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
        //comparing the 2 tags of the player and finishline and then the input.getkeydown and scenmaneger??
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        while (true)
        {
            Debug.Log("hallo");
            if (Input.GetKey(KeyCode.K))
            { //collider of je op een object staat dan de code?
                SceneManager.LoadScene(1);
            }
        }
    }
}
//checkt of de player op de finishline staat en als de player input 1 is gegeven set the player location and spawnpoint to the next lvl
