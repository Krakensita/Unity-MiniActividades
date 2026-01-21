using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public float inactivityTime = 10f; 

    private float lastInputTime;

    void Start()
    {
        ResetInactivityTimer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadRedScene();
        }

        if (Input.anyKeyDown)
        {
            ResetInactivityTimer();
        }

        if (Time.time - lastInputTime >= inactivityTime)
        {
            LoadGreenScene();
        }
    }

    void ResetInactivityTimer()
    {
        lastInputTime = Time.time;
    }

    public void LoadBlueScene()
    {
        SceneManager.LoadScene("E66_Blue");
    }

    void LoadRedScene()
    {
        SceneManager.LoadScene("E66_Red");
    }

    void LoadGreenScene()
    {
        SceneManager.LoadScene("E66_Green");
    }
}
