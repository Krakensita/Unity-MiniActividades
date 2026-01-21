using UnityEngine;

public class E63 : MonoBehaviour
{
    private AudioSource audioSource;
    public  AudioClip pickupCoin;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }

        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlaySound();
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlaySound();
    }

    private void PlaySound()
    {
        if (audioSource == null || pickupCoin == null) return;
        audioSource.PlayOneShot(pickupCoin);
    }
}
