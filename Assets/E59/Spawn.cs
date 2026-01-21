using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public GameObject spawnPrefab;

    void Update()
    {
        if (spawnPrefab == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnPrefab, transform.position, Quaternion.identity);
        }
    }
}
