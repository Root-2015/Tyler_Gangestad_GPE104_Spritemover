using UnityEngine;

public class Health : MonoBehaviour
 
{
      public HealthBar bar;
      public float currentHp;
      public float maxHp;
      public float score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void scoreGoal(float amount)
    {
    score = score + amount;
    }


    public void Takedamage(float amount)
    {
        //Add armor and change in damage taken due to armor
        currentHp = currentHp - amount;
        
        if (bar != null)
            {bar.Hurt();}
        if (!IsAlive())
            {Die();}
    }

    public void Heal(float amount)
    {
        currentHp = currentHp + amount;
        if (currentHp > maxHp) {currentHp = maxHp;}
    }

    public void Die()
    {
    //TODO handle death in health component
        Death death = GetComponent<Death>();
        if (death != null) 
        {
        death.Die();
        }
    }

    public bool IsAlive()
    {
        if (currentHp > 0)
        {return true;}
        else
        {return false;}
    }
}
