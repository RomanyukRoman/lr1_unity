using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    [SerializeField]
    private AudioClip collisionSound;
    private void OnCollisionEnter(Collision collision)
    {
        AudioClip soundToPlay = (collisionSound != null) ? collisionSound : GetDefaultCollisionSound();

        PlayCollisionSound(soundToPlay);
    }
    private void PlayCollisionSound(AudioClip sound)
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.PlayOneShot(sound);
    }

    private AudioClip GetDefaultCollisionSound()
    {
        AudioClip defaultSound = UnityEditor.AssetDatabase.LoadAssetAtPath<AudioClip>("Assets/Audio/rubber-ball-bouncing-98700 (mp3cut.net).mp3");
        return defaultSound;
    }
}
