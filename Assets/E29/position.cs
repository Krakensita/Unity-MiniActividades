using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject boxPrefab;

    private float minX = -8f;
    private float maxX = 8f;
    private float spawnY = 6f;

    void Start()
    {
        if (boxPrefab == null)
        {
            Debug.LogError("Box Prefab no asignado en el Inspector");
            return;
        }

        Vector3 spawnPosition = new Vector3(
            Random.Range(minX, maxX),
            spawnY,
            0f
        );

        boxPrefab.transform.position = spawnPosition;
    }
}

