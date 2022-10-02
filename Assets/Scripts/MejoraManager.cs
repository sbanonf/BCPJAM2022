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
    public TextMeshProUGUI Tienda;
    public TextMeshProUGUI entradas;
    public TextMeshProUGUI salidas;



    public void OnEnable()
    {
        entradas.text = InventarioManager.instance.ingresos.ToString();
        salidas.text = InventarioManager.instance.Egresos.ToString();
        MoneyManager.instance.SetearTexto();
        GameManager.Instance.SetearMes();
    }

    public void PresionBoton() {
        MoneyManager.instance.PayMoney(int.Parse(Credito.text));
        MoneyManager.instance.PayMoney(int.Parse(Tienda.text));
        if (MoneyManager.instance.total >= 0)
        {
            TimeManager.instance.stage = 0;
            GameManager.Instance._mes++;
            InventarioManager.instance.ingresos = 0;
            InventarioManager.instance.Egresos = 0;
            GameManager.Instance.UpdateGameState(GameState.eleccion);
        }
        else if(MoneyManager.instance.total <0) {
            MoneyManager.instance.money = 200;
            MoneyManager.instance.gasto = 0.50 * MoneyManager.instance.money;
            TimeManager.instance.stage = 0;
            GameManager.Instance._mes = 0;
            var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
            foreach (ScriptableIns ins in loadInsumos)
            {
                ins.cantidad = 0;
            }

            GameManager.Instance.UpdateGameState(GameState.perder);                   
        }
    }
}
