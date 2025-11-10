using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public ShipLocation pawn;
    public DamageOnHit enemy;
    public Bestscore highScore;
    public showHighScore text;
    public DeathDestroy killPlayer;
    public GameObject game;
    public bool fail;
    public bool win;
    public float timerMax;
    public float timeRemaining;
    public float realScore;
    public GameObject prefabToCopy;


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
        if (timeRemaining <= 0)
        {
        killPlayer.Die();
        }
        if (pawn == null && !fail)
        {
            Debug.Log("Failure");
            fail = true;
            
            GameObject tempPawn;
            tempPawn = Instantiate(prefabToCopy, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(game);
        }
        if (enemy == null && !win)
        {
        Debug.Log("WINNER");
        win = true;
        }
    }

    public void resetTimer(){}
}
