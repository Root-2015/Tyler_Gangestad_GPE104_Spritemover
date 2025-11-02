using UnityEngine;


public class ShipLocation : MonoBehaviour
{
    public Hero bar;
    public Hero pawn;
    public Transform location;
    public float moveSpeed;
    public float rotateSpeed;
    public float turbo;
// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        location = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { if ( Input.GetKeyDown(KeyCode.T))
	    {
	    float randomX = Random.Range(-10f, 10f);
	    float randomY = Random.Range(-5f, 5f);
	    transform.position = new Vector3(randomX, randomY);
	    }
     
     if (Input.GetKey(KeyCode.W))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.MoveForward(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.MoveForward(pawn.moveSpeed);}
      
      if (Input.GetKey(KeyCode.S))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.MoveBackwards(pawn.moveSpeed*pawn.turbo);}
        else
        {pawn.MoveBackwards(pawn.moveSpeed);}
     
     if (Input.GetKey(KeyCode.A))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.NegativeRotate(pawn.rotateSpeed*pawn.turbo);
         bar.rotate(pawn.rotateSpeed*pawn.turbo);}
        else{pawn.NegativeRotate(pawn.rotateSpeed);}
     
     if (Input.GetKey(KeyCode.D))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.rotate(pawn.rotateSpeed*pawn.turbo);}
        else{pawn.rotate(pawn.rotateSpeed);}
     
      if (Input.GetKeyDown(KeyCode.UpArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveUp(pawn.moveSpeed*pawn.turbo*100);}
        else 
        {pawn.moveUp(pawn.moveSpeed*100);}
      
      if (Input.GetKeyDown(KeyCode.DownArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveDown(pawn.moveSpeed*pawn.turbo*100);}
        else 
        {pawn.moveDown(pawn.moveSpeed*100);}
    
      if (Input.GetKeyDown(KeyCode.LeftArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveLeft(pawn.moveSpeed*pawn.turbo*100);}
        else 
        {pawn.moveLeft(pawn.moveSpeed*100);}

      if (Input.GetKeyDown(KeyCode.RightArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveRight(pawn.moveSpeed*pawn.turbo*100);}
        else 
        {pawn.moveRight(pawn.moveSpeed*100);}
     }
    

        
      
}