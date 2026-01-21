using UnityEngine;

public class seguir : MonoBehaviour
{
    public Transform target;

    public float maxSpeed = 5f;
    public float acceleration = 2f;
    public float deceleration = 2f;

    public float followDistance = 2f;
    public float heightOffset = 0.5f;

    private Vector3 currentVelocity = Vector3.zero;

    void Update()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position - target.forward * followDistance + Vector3.up * heightOffset;

        Vector3 direction = desiredPosition - transform.position;
        float distance = direction.magnitude;
        if (distance < 0.001f) return;
        direction.Normalize();

        float desiredSpeed = maxSpeed;
        if (distance < followDistance)
        {
            desiredSpeed = Mathf.Lerp(0f, maxSpeed, distance / followDistance);
        }

        Vector3 desiredVelocity = direction * desiredSpeed;

        currentVelocity = Vector3.MoveTowards(
            currentVelocity,
            desiredVelocity,
            (currentVelocity.magnitude < desiredVelocity.magnitude ? acceleration : deceleration) * Time.deltaTime
        );

        transform.position += currentVelocity * Time.deltaTime;
    }
}
