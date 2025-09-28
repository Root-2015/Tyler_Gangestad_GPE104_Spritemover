using UnityEngine;

public class ShipLocation : MonoBehaviour
{
	public Transform location;


// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
     { if ( Input.GetKeyDown(KeyCode.C))
	{
	float randomX = Random.Range(-10f, 10f);
	float randomY = Random.Range(-5f, 5f);
	transform.position = new Vector3(randomX, randomY);
	}
     }
}
