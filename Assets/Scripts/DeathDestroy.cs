using UnityEngine;

public class DeathDestroy : Death
{
    public AudioSource audio;
    public AudioListener listen;
    public override void Die()
    {
    if (listen != null)
        {
        listen.enabled = true;
        }
    if (audio != null)
        {
        audio.Play();
        }
    Destroy(gameObject);
    }
}
