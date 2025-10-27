using UnityEngine;

public class shotBullet : Shooter
{
    public Transform trans;
    public GameObject prefabToCopy;
    public GameObject UltraPrefabToCopy;
    public Hero pawn;
    public float upgrade;
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
        if (upgrade == 0){
            Instantiate(prefabToCopy, pawn.transform.position, pawn.transform.rotation);
        }
        else{
            Instantiate(UltraPrefabToCopy, pawn.transform.position, pawn.transform.rotation);
        }
    }

}
