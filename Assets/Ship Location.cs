using UnityEngine;


public class ShipLocation : MonoBehaviour
{
    public ShipLocation pawn;
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
         {pawn.NegativeRotate(pawn.rotateSpeed*pawn.turbo);}
        else{pawn.NegativeRotate(pawn.rotateSpeed);}
     
     if (Input.GetKey(KeyCode.D))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.rotate(pawn.rotateSpeed*pawn.turbo);}
        else{pawn.rotate(pawn.rotateSpeed);}
     
     if (Input.GetKey(KeyCode.W))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.MoveForward(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.MoveForward(pawn.moveSpeed);}
     
      if (Input.GetKeyDown(KeyCode.UpArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveUp(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.moveUp(pawn.moveSpeed);}
      
      if (Input.GetKeyDown(KeyCode.DownArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveDown(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.moveDown(pawn.moveSpeed);}
    
      if (Input.GetKeyDown(KeyCode.LeftArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveLeft(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.moveLeft(pawn.moveSpeed);}

      if (Input.GetKeyDown(KeyCode.RightArrow))
        if (Input.GetKey(KeyCode.LeftShift))
         {pawn.moveRight(pawn.moveSpeed*pawn.turbo);}
        else 
        {pawn.moveRight(pawn.moveSpeed);}
     }
    

        
      
public void MoveForward(float moveSpeed)
        {
        // this helps move forward in the direction of the sprite
        transform.position = transform.position + (transform.up * moveSpeed * Time.deltaTime);
        }

public void MoveBackwards(float moveSpeed)
        {
        // this helps move back in the direction of the sprite
        transform.position = transform.position + (transform.up * -moveSpeed * Time.deltaTime);
        }

public void rotate(float rotateSpeed)
        {
        // this helps turn in the direction of the sprite
        transform.Rotate(0.0f, 0.0f, -rotateSpeed * Time.deltaTime);
        }

public void NegativeRotate(float rotateSpeed)
        {
        // this helps turn in the direction of the sprite
        transform.Rotate(0.0f, 0.0f, rotateSpeed * Time.deltaTime);
        }
        
void moveUp(float moveSpeed)
        {
        // this helps move up in the direction of the game
        transform.position = transform.position + (Vector3.up * moveSpeed * Time.deltaTime);
        }
void moveDown(float moveSpeed)
        {
        // this helps move down in the direction of the game
        transform.position = transform.position + (Vector3.down * moveSpeed * Time.deltaTime);}
void moveLeft(float moveSpeed)
        {
        // this helps move left in the direction of the game
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);}
void moveRight(float moveSpeed)
        {
        // this helps move right in the direction of the game
        transform.position = transform.position + (Vector3.right * moveSpeed * Time.deltaTime);}    
        }