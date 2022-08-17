/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static TimeManager unicaInstancia;
    public float timerLeft;
    public static bool timerOn = false;
    //public Text timerTxt;

    void Awake()
    {

        if (TimeManager.unicaInstancia == null)
        {
            TimeManager.unicaInstancia = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {

            Destroy(gameObject);
        }
    }

    void Start()
    {
        timerOn = true;
        // timerTxt = GameObject.FindWithTag("timer_txt").GetComponent<Text>();
    }

    void Update()
    {
        if (timerOn)
        {
            if (timerLeft > 0)
            {
                timerLeft -= Time.deltaTime;
                updateTimer(timerLeft);
            }
            else
            {
                Debug.Log("El tiempo se terminó!");
                timerLeft = 0;
                timerOn = false;
            }
        }
        //esto va en el test y despues al manager general del juego
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        // 	SceneManager.LoadScene(1);
        // }
        // if (Input.GetKeyDown(KeyCode.I))
        // {
        // 	TimerManager.Pausar();
        // }
        // if (Input.GetKeyDown(KeyCode.O))
        // {
        // 	TimerManager.Despausar();
        // }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        Debug.Log(string.Format("{0:00} : {1:00}", minutes, seconds));
        // timerTxt.text  = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public static void Pausar()
    {
        timerOn = false;
    }

    public static void Despausar()
    {
        timerOn = true;
    }
}

*/