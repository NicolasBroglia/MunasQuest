using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPlayer : MonoBehaviour
{

    //hp bar
    public Image hpBar;
    public float currentHp;
    public float maxHp = 100f;

    //pause
    private bool pauseActive;
    public GameObject pauseMenu;

    void Start()
    {
        
    }

    void Update()
    {
        currentHp = PlayerMove.playerHP;
        hpBar.fillAmount = currentHp / maxHp;

        TogglePause();
    }

    public void TogglePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseActive)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    //resume
    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseActive = false;
    }
    //pause
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pauseActive = true;
    }
    //back to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
