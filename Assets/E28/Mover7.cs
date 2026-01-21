using UnityEngine;

public class Mover7 : MonoBehaviour
{
    public float speed = 5f;
    private float h;
    private float v;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            y = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            y = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x = -1f;
        }
        Vector3 direction = new Vector3(x, y, 0f);
        transform.position += direction * speed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(h, 0f, v);
        Vector3 velocity = movement * speed;
        velocity.y = rb.linearVelocity.y;
        rb.linearVelocity = velocity;
    }
}
