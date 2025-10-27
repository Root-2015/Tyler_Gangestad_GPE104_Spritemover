using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public ShipLocation pawn;
    public DamageOnHit enemy;
    public bool fail;
    public bool win;
    public float timerMax;
    public float timeRemaining;
    public float realScore;


    void awake(){
            if (manager == null)
            {manager = this;}
            else
            {Destroy(gameObject);}
            
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeRemaining = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (pawn == null && !fail)
        {
        Debug.Log("Failure");
        fail = true;
        }
        if (enemy == null && !win)
        {
        Debug.Log("WINNER");
        win = true;
        }
    }

    public void resetTimer(){}
}
