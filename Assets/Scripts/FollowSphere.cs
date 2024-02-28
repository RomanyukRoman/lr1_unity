using UnityEngine;

public class FollowSphere : MonoBehaviour
{
    public Transform sphere; 
    public float distance = 5f; 
    public float offsetHeight = 2f; 
    public float speed = 2f; 

    void Update()
    {
        Vector3 targetPosition = sphere.position + new Vector3(distance, offsetHeight, -1);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        transform.LookAt(sphere);
    }
}
