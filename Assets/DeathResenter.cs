using UnityEngine;

public class DeathResenter : Death
{
    public override void Die()
    {
    transform.position = Vector3.zero;

    base.Die();
    }
}
