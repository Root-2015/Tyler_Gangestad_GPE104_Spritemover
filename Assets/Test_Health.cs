using UnityEngine;

public class Test_Health : MonoBehaviour
{
    public Hero pawnToTest;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pawnToTest.death.Die();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            pawnToTest.health.Takedamage(1);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            pawnToTest.health.Heal(1);
        }
    }
}
