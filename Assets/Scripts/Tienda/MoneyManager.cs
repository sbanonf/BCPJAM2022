using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public GameObject timeManager;
    public static MoneyManager instance;
    public int money = 100;
    bool perdio = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        } 
    }
    private void Update()
    {
        if (money < 0) { //Verificar Stage.
            perdio = true;
        }
        SetearTexto();
    }
    public void AddMoney(int a) {
        money += a;
        SetearTexto();
        
    }
    public void PayMoney(int b) {
        money -= b;
        SetearTexto();

    }

    public void SetearTexto() {

            TextMeshProUGUI dinero = GameObject.FindGameObjectWithTag("Dinero").GetComponent<TextMeshProUGUI>();
            dinero.text = "S/ " + money.ToString();

    }


}
