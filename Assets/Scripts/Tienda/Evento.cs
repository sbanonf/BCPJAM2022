using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Evento : MonoBehaviour
{
    public ScriptableEvento evento;
    public TextMeshProUGUI enunciado;
    public Image _sprite;
    public TextMeshProUGUI TextoVerde;
    public TextMeshProUGUI TextoRojo;


    private void Start()
    {
        enunciado.text = evento.texto;
        _sprite.sprite = evento.sprite;
        TextoVerde.text = evento.boton1;
        TextoRojo.text = evento.boton2;
    }

    
}
