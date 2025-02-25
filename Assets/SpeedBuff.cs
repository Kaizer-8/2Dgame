using UnityEngine;

public class SpeedBuff : PowerupEffects
{
    public float Speed;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>().speed.value += amount;//de speed van mijn movement class moet veranderd worden
    }
}
