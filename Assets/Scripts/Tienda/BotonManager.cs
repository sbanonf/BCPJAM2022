using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BotonManager : MonoBehaviour
{
    private GameManager gameManager;
    public Button boton;
    public TextMeshProUGUI text;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (text.text == "Ir Por Materiales" || text.text == "Volver por materiales")
        {
            boton.onClick.AddListener(gameManager.ChangeMateriales);
        }
        else if (text.text == "Atender la Tienda")
        {
            boton.onClick.AddListener(gameManager.ChangeTienda);
        }

    }
    public void Empezar() {
        AudioManager.instance.Play("click");
        SceneManager.LoadScene("eleccion");
    }
    public void Reiniciar() {
        AudioManager.instance.Play("click");
        SceneManager.LoadScene("Inicio");
    }
    public void Creditos() {
        AudioManager.instance.Play("click");
        SceneManager.LoadScene("Creditos");
    }
    public void Tutorial() {
        AudioManager.instance.Play("click");
        SceneManager.LoadScene("Tutorial");
    }
}
