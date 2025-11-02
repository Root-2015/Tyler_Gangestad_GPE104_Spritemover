using UnityEngine;

public class SoundBoard : MonoBehaviour
{
    public Hero Sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sound = GetComponent<Hero>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
