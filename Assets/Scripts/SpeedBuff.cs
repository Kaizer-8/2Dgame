using UnityEngine;

public class SpeedBuff : MonoBehaviour
{
    public void Apply(GameObject target)
    {
        if (target == null)
        {
            target.GetComponent<Movement>().SetSpeed();
        }
    }
}
//in mijn movement class heb ik een class die de speed regeld die wil ik veranderen met deze powerup functie