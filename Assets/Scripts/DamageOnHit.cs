using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageDone;
    public bool isInstaKill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (isInstaKill == true)
            {
            Death death = other.gameObject.GetComponent<Death>();
            if (death != false)
                death.Die();
            }
        if (otherHealth != null)
            {
                otherHealth.Takedamage(damageDone);
            }
            
    }
}
