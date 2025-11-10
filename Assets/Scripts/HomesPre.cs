using UnityEngine;

public class HomesPre : MonoBehaviour
{
    public GameObject prefabToCopyQ;
    public GameObject prefabToCopyE;
    private GameObject game;
    private GameObject settings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (prefabToCopyQ != null){
            if (Input.GetKeyDown(KeyCode.Q))
            { settings = Instantiate(prefabToCopyQ, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(gameObject);}
        }
        if (prefabToCopyE != null)
        if (Input.GetKeyDown(KeyCode.E))
            {game = Instantiate(prefabToCopyE, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(gameObject);}
    }
}
