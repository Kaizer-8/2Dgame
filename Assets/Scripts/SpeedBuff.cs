using UnityEngine;

public class SpeedBuff : PowerupEffects
{
    public float Speed;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Movement>().SetSpeed();
    }
}
//in mijn movement class heb ik een class die de speed regeld die wil ik veranderen met deze powerup functie