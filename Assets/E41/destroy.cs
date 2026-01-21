using UnityEngine;

public class destroy : MonoBehaviour
{
    public float destroyRadius = 1f;

    void Update()
    {

        DestroyObject();
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
