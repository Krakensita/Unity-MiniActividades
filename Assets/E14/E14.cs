using UnityEngine;

public class E14 : MonoBehaviour
{
    private int num;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                num = i * j;
                Debug.Log($"{i} * {j} = {num}");
            }
        }
    }
}
