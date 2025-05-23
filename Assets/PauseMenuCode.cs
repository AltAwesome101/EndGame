using UnityEngine;

public class PauseMenuCode : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    
    public void Settings() 
    {

    }
    public void Quit() 
    {
        Application.Quit();
    }

}
