using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventoBttonManager : MonoBehaviour
{
    public Button boton;
    public Button boton2;
    public TextMeshProUGUI text;
    public GameObject panel;

    public void Prestamo() {
        AudioManager.instance.Play("confirmacion");
        MoneyManager.instance.money -= 200;
        Destroy(panel);
    }
    public void PrestamoNegativo() {
        AudioManager.instance.Play("click");
        Destroy(panel);
    }
    public void Podrirse() {
        AudioManager.instance.Play("confirmacion");
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach (ScriptableIns insumo in loadInsumos)
        {
            insumo.cantidad = 0;
        }
        Destroy(panel);
    }
    public void PodrirseCuota() {
        AudioManager.instance.Play("click");
        MoneyManager.instance.money -= 500;
        if (MoneyManager.instance.money < 0) {
            MoneyManager.instance.money += 500;
            text.text = "No te alcanzo para pagar el seguro, perdiste todo los insumos que habias recogido, se han echado a perder";
            gameObject.SetActive(false);
        }
    }

    public void HipsterPositivo() {
        AudioManager.instance.Play("confirmacion");
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableCuy));
        foreach (ScriptableCuy insumo in loadInsumos)
        {
            if (insumo.name == "Hipster") {
                insumo.precio += 10;
            }
        }
        Destroy(panel);
    }

    public void HipsterNegativo() {
        AudioManager.instance.Play("click");
        MoneyManager.instance.money += 100;
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach (ScriptableIns insumo in loadInsumos)
        {
            if (insumo.name == "Queso")
            {
                insumo.cantidad = 0;
            }
        }
        Destroy(panel);
    }



}
