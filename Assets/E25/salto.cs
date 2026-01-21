using UnityEngine;

public class salto : MonoBehaviour
{
    public float jump = 5f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
    }
}
