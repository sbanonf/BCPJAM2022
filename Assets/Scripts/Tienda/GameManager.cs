using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;
    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance != null)
        {
            Destroy(this);

        }

    }
    private void Start()
    {
        //Singleton
        //Maquina de Estados
        //
    }

    public void ChangeMateriales()
    {
        UpdateGameState(GameState.minijuego);
    }
    public void ChangeTienda() {
        UpdateGameState(GameState.tienda);
    }
    public void HandleEleccion() { 
    }
    public void UpdateGameState(GameState newGameState) {
        switch (newGameState)
        {
            case GameState.eleccion:
                SceneManager.LoadScene("eleccion");
                break;
            case GameState.minijuego:
                SceneManager.LoadScene("minijuego");
                break;
            case GameState.tienda:
                SceneManager.LoadScene("Tienda");
                break;
            case GameState.mejora:
                break;
            case GameState.perder:
                break;
            default:
                break;
        }
        OnGameStateChanged?.Invoke(newGameState);
    }
}
public enum GameState {
        eleccion,
        minijuego,
        tienda,
        mejora,
        perder
}
