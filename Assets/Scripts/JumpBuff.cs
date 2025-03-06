using UnityEngine;

public class JumpBuff : PowerupEffects
{
    public float JumpingPower;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>().SetJumpingPower();
    }
}
