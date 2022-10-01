using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MejoraManager : MonoBehaviour
{
    public TextMeshProUGUI Ahorros;
    public TextMeshProUGUI Mes ;
    public TextMeshProUGUI Credito;
    public TextMeshProUGUI[] montos;
    private List<int> m = new List<int>();

    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;


    public void OnEnable()
    {
        Debug.Log(montos.Length);
        for (int i = 0; i < montos.Length; i++) {
                Debug.Log(montos[i].text);
                m.Add(int.Parse(montos[i].text));
        }
        MoneyManager.instance.SetearTexto();
        GameManager.Instance.SetearMes();
    }

    public void PresionBoton() {
        MoneyManager.instance.PayMoney(int.Parse(Credito.text));
        if (toggle1.isOn && toggle2.isOn == false && toggle3.isOn == false)
        {
            MoneyManager.instance.PayMoney(m[0]);
        }
        if (toggle2.isOn && toggle3.isOn == false && toggle1.isOn == false)
        {
            MoneyManager.instance.PayMoney(m[1]);
        }
        if (toggle3.isOn && toggle1.isOn == false && toggle2.isOn == false)
        {
            MoneyManager.instance.PayMoney(m[2]);
        }
        if (toggle1.isOn && toggle2.isOn == true && toggle3.isOn == false)
        {
            MoneyManager.instance.PayMoney(m[0]);
            MoneyManager.instance.PayMoney(m[1]);
        }
        if (toggle1.isOn && toggle2.isOn && toggle3.isOn)
        {
            MoneyManager.instance.PayMoney(m[0]);
            MoneyManager.instance.PayMoney(m[1]);
            MoneyManager.instance.PayMoney(m[2]);
        }
        if (toggle1.isOn == false && toggle2.isOn && toggle3.isOn)
        {
            MoneyManager.instance.PayMoney(m[1]);
            MoneyManager.instance.PayMoney(m[2]);

        }
        if (toggle1.isOn && toggle3.isOn && toggle2.isOn == false) {
            MoneyManager.instance.PayMoney(m[0]);
            MoneyManager.instance.PayMoney(m[2]);
        }
        if (MoneyManager.instance.total >= 0)
        {
            TimeManager.instance.stage = 0;
            GameManager.Instance._mes++;
            GameManager.Instance.UpdateGameState(GameState.eleccion);
        }
        else if(MoneyManager.instance.money <0) {
            MoneyManager.instance.money = 200;
            MoneyManager.instance.gasto = 0.50 * MoneyManager.instance.money;
            TimeManager.instance.stage = 0;
            var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
            foreach (ScriptableIns ins in loadInsumos)
            {
                ins.cantidad = 0;
            }

            GameManager.Instance.UpdateGameState(GameState.perder);                   
        }
    }
}
