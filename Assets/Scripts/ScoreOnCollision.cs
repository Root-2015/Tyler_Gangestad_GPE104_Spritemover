using UnityEngine;

public class ScoreOnCollision : MonoBehaviour
{
    public float scoreAmount;
    public GameManager manager;
    public AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
            {
                otherHealth.scoreGoal(scoreAmount);
                manager.realScore = manager.realScore+scoreAmount;
                audio.Play();
            }
            
    }
}
