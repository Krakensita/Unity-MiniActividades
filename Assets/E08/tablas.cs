using UnityEngine;

public class E08 : MonoBehaviour
{
    public int numero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Debug.Log(numero + " x " + i + " = " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
