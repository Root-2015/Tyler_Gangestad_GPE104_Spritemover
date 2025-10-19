using UnityEngine;

public class shotBullet : Shooter
{
    public Transform trans;
    public GameObject prefabToCopy;
    public Hero pawn;
    void Start()
    {
     trans = gameObject.GetComponent<Transform>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shot();
        }
    }
    
    public override void Shot()
    {
        Instantiate(prefabToCopy, pawn.transform.position, pawn.transform.rotation);
    
    }

}
