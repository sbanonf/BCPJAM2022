using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ins : MonoBehaviour
{
    public ScriptableIns insumo;
    public TextMeshProUGUI nombre;
    public Image _sprite;
    void Start()
    {
        nombre.text = insumo.nombre;
        _sprite.sprite = insumo._sprite;
    }

}
