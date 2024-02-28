using UnityEngine;

public class ResizeSphere : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        float newSize = 0.3f;
        float size = 1;
        if (collision.gameObject.tag == "ResizeTile")
        {
            transform.localScale = new Vector3(newSize, newSize, newSize);
        }
        else
        {
            if(collision.gameObject.tag == "EnlargeTile")
            {
                transform.localScale = new Vector3(size, size, size);
            }
        }
    }
}
