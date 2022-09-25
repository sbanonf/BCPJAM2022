using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    public int stage=0;
    public int maxstage = 4;
    public float TiempoTurno=30;
    public float TiempoMax = 30;
    public bool sepuede = false;

    public GameManager _gameManager;
    public TextMeshProUGUI timer;

    private void OnEnable()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
        Timer();
    }

    public void Timer() {
        timer = GameObject.FindGameObjectWithTag("TimerText").GetComponent<TextMeshProUGUI>();
        timer.text = TiempoTurno.ToString("f0");
        if (sepuede == true)
        {
            if (stage < maxstage)
            {
                TiempoTurno = TiempoTurno - Time.deltaTime;
                if (TiempoTurno <= 0)
                {
                    TiempoTurno = TiempoMax;
                    stage++;
                    if (stage < maxstage)
                    {
                        _gameManager.UpdateGameState(GameState.eleccion);
                        sepuede = false;
                    }
                }
            }
            else
            {
                _gameManager.UpdateGameState(GameState.mejora);
                sepuede = false;
            }
        }

    }

    public void AumentarStage() {


    }

}
