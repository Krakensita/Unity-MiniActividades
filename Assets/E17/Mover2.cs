using UnityEngine;

public class Mover2 : MonoBehaviour
{
    public float velocidad = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(-1, -1, 0);
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}
