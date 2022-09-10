using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPlayer : MonoBehaviour
{

    //hp bar
    public Image hpBar;
    public static float currentHp;
    public float maxHp = 100f;

    //pause
    private bool pauseActive;
    public GameObject pauseMenu;

    public GameObject gameOverMenu;
    public GameObject HPbar;
    public GameObject finalBossQuestWindow;
    public GameObject finalBossHpBar;
    void Update()
    {
        currentHp = PlayerHP.playerHP;
        hpBar.fillAmount = currentHp / maxHp;

        TogglePause();
       // GameOver();
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
    public GameObject finalBoss;
    public void GameOver()
    {
       if(finalBoss == null)
       {
            finalBossHpBar.SetActive(false);
            gameOverMenu.SetActive(false);
            HPbar.SetActive(false);
            finalBossQuestWindow.SetActive(false);
            pauseMenu.SetActive(false);
            gameOverMenu.SetActive(true);
       }
        else
        {
            gameOverMenu.SetActive(false);
        }
    }
   
}
