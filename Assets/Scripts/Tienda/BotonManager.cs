using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BotonManager : MonoBehaviour
{
    private GameManager gameManager;
    public Button boton;
    public TextMeshProUGUI text;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (text.text == "Ir Por Materiales" ||   text.text== "Materiales")
        {
            boton.onClick.AddListener(gameManager.ChangeMateriales);
        }
        else if(text.text == "Atender la Tienda") {
            boton.onClick.AddListener(gameManager.ChangeTienda);
        }
    }
    
}
