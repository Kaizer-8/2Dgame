using UnityEngine;

public class SpeedBuff : PowerupEffects
{
    public float Speed;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>();
    }
}
