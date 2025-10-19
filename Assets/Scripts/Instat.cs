using UnityEngine;

public class Instat : MonoBehaviour
{
        
    public GameObject prefabToCopy;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject tempPawn;
            tempPawn = Instantiate(prefabToCopy, Vector3.zero, Quaternion.identity) as GameObject;
            if (tempPawn != null)
            {
            Hero pawnComponent = tempPawn.GetComponent<Hero>();
            }
            Health healthComponent = tempPawn.GetComponent<Health>();
            if (healthComponent != null)
            {
            healthComponent.maxHp = 1000;
            
            }
        }
    } 
}
