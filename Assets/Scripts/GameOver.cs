using UnityEngine;

public class GameOver : MonoBehaviour
{
    public delegate void BallCollisionEventHandler();
    public static event BallCollisionEventHandler OnBallCollision;
    public AudioClip collisionSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
            gameObject.SetActive(false);
        }
    }
}
