using UnityEngine;

public class calculadora : MonoBehaviour
{
    public float number1;
    public float number2;

    public string operation;

    void Start()
    {
        float result = 0f;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = number1 + number2;
                break;

            case "-":
                result = number1 - number2;
                break;

            case "*":
                result = number1 * number2;
                break;

            case "/":
                if (number2 != 0)
                    result = number1 / number2;

                break;

            case "%":
                if (number2 != 0)
                    result = number1 % number2;
                break;

            default:
                Debug.LogError("Invalid operation. Use + - * / %");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Debug.Log(number1 + " " + operation + " " + number2 + " = " + result);
        }
    }
}

