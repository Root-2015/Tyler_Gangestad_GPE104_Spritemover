using UnityEngine;

public class shot : MonoBehaviour
{
    public Hero pawn;
    public Transform location;
    public float moveSpeed;
    void Start()
    {
        location = this.gameObject.GetComponent<Transform>();
        pawn = this.gameObject.GetComponent<Hero>();
    }

    // Update is called once per frame
    void Update()
    {
        pawn.MoveForward(pawn.moveSpeed);
    }
}