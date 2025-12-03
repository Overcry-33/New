using UnityEngine;

public class EndTriggerUI : MonoBehaviour
{
    public GameObject imageObject;    // Managed_to_escape
    public AudioSource audioSource;   // sound to play
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (imageObject != null)
                imageObject.SetActive(true);

            if (audioSource != null)
                audioSource.Play();
        }
    }
}
