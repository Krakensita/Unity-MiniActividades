using UnityEngine;

public class destroy2 : MonoBehaviour
{
    public float destroyRadius = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyObject();
        }
    }

    void DestroyObject()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, destroyRadius);

        foreach (Collider col in colliders)
        {
            if (col.gameObject != gameObject)
            {
                Destroy(col.gameObject);
            }
        }
    }
}
