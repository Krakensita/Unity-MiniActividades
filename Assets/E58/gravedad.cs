using UnityEngine;

public class gravedad : MonoBehaviour
{
    private bool gravedadActiva = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gravedadActiva = Physics.gravity.y < 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.gravity = -Physics.gravity;
        }
    }
}
