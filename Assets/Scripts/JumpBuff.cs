using UnityEngine;

public class JumpBuff : MonoBehaviour
{
    public void Apply(GameObject target)
    {
        if (target == null)//if my player coordinate are equal to the powerup location it will activate
        {
            target.GetComponent<Movement>().SetJumpingPower();
        }
    }
}
