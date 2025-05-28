using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = true;
        }

        if (isPaused)
        {
            Time.timeScale = 0f;
            pauseUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            pauseUI.SetActive(false);
        }
    }

    public void Resume()
    {
        isPaused = false;
    }
}
