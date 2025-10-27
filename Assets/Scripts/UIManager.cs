using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public Image timerImage;
    public TMP_Text bottomtext;
    public TMP_Text topText;
    public GameManager manager;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
        updateScore();
    }
  
    void updateScore(){
        topText.text = "Score: " + manager.realScore;
    }

    void updateTimer(){
        manager.timeRemaining -= Time.deltaTime;
        float displayTimeLeft = Mathf.Round (manager.timeRemaining);
    bottomtext.text = "Time Remaining: " + displayTimeLeft;
    }
}
