using UnityEngine;

public class Mover5 : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
