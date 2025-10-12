using UnityEngine;

public class Hero : MonoBehaviour
{
    [Header("Movement")]
    public Hero pawn;
    public Transform location;
    public float moveSpeed;
    public float rotateSpeed;
    public float turbo;
    [Header("Health Componants")]
    public Health health;
    public Death death;
     

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = GetComponent<Health>();
        death = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTowards(Vector3 pointToMoveTowards)
        {
        //Find vector to that point, normalize it, mutiply by speed
        Vector3 moveVector = pointToMoveTowards - transform.position;
        moveVector.Normalize();
        moveVector *= moveSpeed;
        moveVector *= Time.deltaTime;
        transform.position = transform.position+ moveVector;
        }

    public void MoveTowards(GameObject objectToMoveTowards)
        {
        MoveTowards(objectToMoveTowards.transform);
        
        }

    public void MoveTowards(Transform TransformToMoveTowards)
        {
        MoveTowards(TransformToMoveTowards.position);
        
        }

    public void MoveTowards(Hero pawnToMoveTowards)
        {
            MoveTowards(pawnToMoveTowards.gameObject);
        }

    public void MoveTowards (ShipLocation controllerToMoveTowards)
        {
        MoveTowards(controllerToMoveTowards.pawn);
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
        
    public void moveUp(float moveSpeed)
        {
        // this helps move up in the direction of the game
        transform.position = transform.position + (Vector3.up * moveSpeed * Time.deltaTime);
        }
    
    public void moveDown(float moveSpeed)
        {
        // this helps move down in the direction of the game
        transform.position = transform.position + (Vector3.down * moveSpeed * Time.deltaTime);}
   
    public void moveLeft(float moveSpeed)
        {
        // this helps move left in the direction of the game
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);}
    public void moveRight(float moveSpeed)
        {
        // this helps move right in the direction of the game
        transform.position = transform.position + (Vector3.right * moveSpeed * Time.deltaTime);}    
        }
        
        
        