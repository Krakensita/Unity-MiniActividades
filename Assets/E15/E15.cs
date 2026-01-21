using UnityEngine;

public class E15 : MonoBehaviour
{
    public int playerA;
    private int playerB;
    private int pointsA = 0;
    private int pointsB = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (pointsA < 5 && pointsB < 5)
        {
            playerB = Random.Range(1, 4);
            Jugada();
        }

        Debug.Log($"Resultado final - A: {pointsA}, B: {pointsB}");
    }

    void Jugada()
    {
        if (playerA == playerB)
        {
            Debug.Log("Empate");
        }
        else if ((playerA == 1 && playerB == 3) || (playerA == 2 && playerB == 1) || (playerA == 3 && playerB == 2))
        {
            pointsA++;
        }
        else
        {
            pointsB++;
        }
    }
}
