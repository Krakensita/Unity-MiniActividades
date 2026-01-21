using UnityEngine;

public class randomgenerator : MonoBehaviour
{
    private int num;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        num = Random.Range(-10, 11);
        Debug.Log(num);
    }
}
