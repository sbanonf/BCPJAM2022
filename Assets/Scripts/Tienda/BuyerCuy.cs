using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyerCuy : MonoBehaviour
{
    public ScriptableCuy cuy;
    public ScriptableIns insumo;
    public TextMeshProUGUI cantidad;
    public TextMeshProUGUI precio;
    public Image objeto;
    public Image scuy;

    private void Start()
    {
        InitializeUI();

    }
    public void InitializeUI() {
        cantidad.text = cuy.cantidad.ToString();
        scuy.sprite = cuy._sprite;
        precio.text = cuy.precio.ToString();
        objeto.sprite = insumo._sprite;
    }

}
