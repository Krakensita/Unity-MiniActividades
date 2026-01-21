using UnityEngine;

public class Operacion : MonoBehaviour
{
    private int number1;
    private int number2;

    private int operation;
    private string signo;

    void Start()
    {
        number1 = Random.Range(1, 101);
        number2 = Random.Range(1, 101); 
        operation = Random.Range(1, 6);
     
        int result = 0;
        bool validOperation = true;

        switch (operation)
        {
            case 1:
                signo = "+";
                result = number1 + number2;
                break;

            case 2:
                signo = "-";
                result = number1 - number2;
                break;

            case 3:
                signo = "*";
                result = number1 * number2;
                break;

            case 4:
                signo = "/";
                if (number2 != 0)
                    result = number1 / number2;

                break;

            case 5:
                signo = "%";
                if (number2 != 0)
                    result = number1 % number2;
                break;

        }

        if (validOperation)
        {
            Debug.Log(number1 + " " + signo + " " + number2 + " = " + result);
        }
    }
}
