using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public shotBullet shoot;
    void OnTriggerEnter2D(Collider2D other){
        shoot.upgrade = shoot.upgrade+1;
    }
}
