using UnityEngine;

public class media : MonoBehaviour
{
    public int numA;
    public int numB;
    public int numC;
    private int sumar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sumar = (numA + numB + numC) / 3;
        Debug.Log(sumar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
