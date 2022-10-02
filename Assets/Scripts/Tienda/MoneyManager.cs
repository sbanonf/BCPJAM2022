using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public GameObject timeManager;
    public static MoneyManager instance;
    [SerializeField]
    public Sprite ahorroim;
    public Sprite gastoim;
    public Sprite peligros;
    public double money = 200;
    public double gasto;
    public double total;
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
        gasto = 0.5*money;
        total = money + gasto;
    }
    private void Update()
    {
        SetearTexto();
    }
    public void AddMoney(int a) {
        money += a*0.50;
        gasto += a* 0.50;
        SetearTotal();
        SetearTexto();
        
    }
    public void PayMoney(int b) {
        
        if (gasto < 0)
        {
            money -= b;
        }
        else if(gasto >= 0) {
            gasto -= b;
        }
        if (SceneManager.GetActiveScene().name == "Mejorar") {


            if (total - b >= 0)
            {
                double vai = money;
                double vgi = gasto;
                if (vai - b <= 0)
                {
                    money = 0;
                }
                if (vgi - b <= 0)
                {
                    gasto = 0;
                }
            }
            else {
                total -= b;
            }
            
            
        }
        SetearTexto();
        SetearTotal();

    }
    public void SetearTotal() {
        total = money + gasto;
    }

    public void SetearTexto() {

        TextMeshProUGUI dinero = GameObject.FindGameObjectWithTag("Dinero").GetComponent<TextMeshProUGUI>();


        if (SceneManager.GetActiveScene().name == "minijuego")
        {
            GameObject gastos = GameObject.FindGameObjectWithTag("GastoIg");
            Debug.Log(gastos);
            if (gasto >= 0) {
                gastos.SetActive(true);
                gastos.GetComponent<Image>().sprite = gastoim;
                dinero.text = "S/" + gasto.ToString();
            }
            if (gasto <0) {
                gastos.GetComponent<Image>().sprite = peligros;
                dinero.color = Color.red;
                dinero.text = "S/" + money.ToString();
            }
        }
        else if (SceneManager.GetActiveScene().name == "Tienda")
        {
            Image ahorro = GameObject.FindGameObjectWithTag("AhorroIg").GetComponent<Image>(); ;
            dinero.text = "S/" + money.ToString();
            ahorro.sprite = ahorroim;
        }
        else if (SceneManager.GetActiveScene().name == "Mejorar") {
            dinero.text = "S/" + total.ToString();        
        }          
    }



}
