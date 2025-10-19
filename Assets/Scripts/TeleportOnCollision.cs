using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
    float randomX = Random.Range(-5F, 5f);
	    float randomY = Random.Range(-5f, 5f);
	    transform.position = new Vector3(randomX, randomY);
    }
}

