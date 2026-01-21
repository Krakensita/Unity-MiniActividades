using UnityEngine;

public class Mover3 : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(-1, 1, 0);
        transform.position += direccion * speed * Time.deltaTime;
    }
}
