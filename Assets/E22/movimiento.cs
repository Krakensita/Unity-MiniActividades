using UnityEngine;

public class movimiento : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 3f;

    void Update()
    {
        transform.position += moveDirection.normalized * speed * Time.deltaTime;
    }
}
