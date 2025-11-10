using UnityEngine;
using TMPro;
public class showHighScore : MonoBehaviour
{
    public TMP_Text text;
    public Bestscore High;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Score()
    {
        text.text = "High score: " + High.bestScore;
    }

}