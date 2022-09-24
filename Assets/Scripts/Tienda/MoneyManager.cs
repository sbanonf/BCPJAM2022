using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public GameObject timeManager;
    public int money = 100;
    bool perdio = false;
    public TextMeshProUGUI dinero;

    private void Awake()
    {
        SetearTexto();
    }
    private void Update()
    {
        if (money < 0) { //Verificar Stage.
            perdio = true;
        }
    }
    public void AddMoney(int a) {
        money += a;
        SetearTexto();
        
    }
    public void PayMoney(int b) {
        money -= b;
        SetearTexto();

    }

    void SetearTexto() {
        dinero.text = "S/ " + money.ToString();
    }


}
