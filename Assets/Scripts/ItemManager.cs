using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;


public class ItemManager : MonoBehaviour
{
    public static ItemManager itemManagerInstance;
    public ScriptableIns[] scriptableIns;

    private void Awake()
    {
        if (itemManagerInstance == null)
            itemManagerInstance = this;
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        SetearTexto();
    }

    public GameObject floatingText;
    public void showValue(InsumoData insumoData, Transform transformCanasta)
    {
        var t = Instantiate(floatingText, transformCanasta.position, Quaternion.identity);
        t.GetComponent<TextMeshPro>().text = "-/s." + insumoData.insumo.costo;
    }

    public TextMeshProUGUI amounts;

    public void SetearTexto()
    {
        amounts = GameObject.FindGameObjectWithTag("IsumosText").GetComponent<TextMeshProUGUI>();
        amounts.text = "";
        for (int i = 0; i < scriptableIns.Length; i++)
        {
            amounts.text = amounts.text + "   " + scriptableIns[i].nombre + "|" + scriptableIns[i].cantidad;
        }
    }

}
