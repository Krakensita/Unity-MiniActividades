using UnityEngine;

public class E13 : MonoBehaviour
{
    private int num;
    private int count;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (count < 100)
        {
            count++;
            num = Random.Range(1, 101);
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
