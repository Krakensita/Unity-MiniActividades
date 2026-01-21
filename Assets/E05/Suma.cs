using UnityEngine;

public class Suma : MonoBehaviour
{
    public int numA;
    public int numB;
    private int sumar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sumar = numA + numB;
        Debug.Log(sumar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
