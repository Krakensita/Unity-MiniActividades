using UnityEngine;

public class E11 : MonoBehaviour
{
    public int playerA;
    private int playerB;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerB = Random.Range(1, 4);
        Jugada();
    }

    // Update is called once per frame
    void Jugada()
    {
        if (playerA == playerB)
        {
            Debug.Log("Empate");
        }
        else if ((playerA == 1 && playerB == 3) || (playerA == 2 && playerB == 1) || (playerA == 3 && playerB == 2))
        {
            Debug.Log("Gana jugador A");
        }
        else
        {
            Debug.Log("Gana jugador B");
        }
    }
}
