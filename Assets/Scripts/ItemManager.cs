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
    public TextMeshProUGUI[] textos;
    public Image[] images;

    private void Awake()
    {
        if (itemManagerInstance == null)
            itemManagerInstance = this;
        else
        {
            Destroy(gameObject);
        }
        
    }

    private void OnLevelWasLoaded()
    {
        SetearTexto();
    }
    private void Update()
    {
        SetearTexto();
    }

    public GameObject floatingText;
    public GameObject floatingTextRed;
    public void showValue(InsumoData insumoData, Transform transformCanasta)
    {
        var t = Instantiate(floatingText, transformCanasta.position, Quaternion.identity);
        t.GetComponent<TextMeshPro>().text = "-/s." + insumoData.insumo.costo;
    }
    public void showValue(int costo, Transform transformCanasta)
    {
        var t = Instantiate(floatingTextRed, transformCanasta.position, Quaternion.identity);
        t.GetComponent<TextMeshPro>().text = "-/s." + costo;
    }

    public TextMeshProUGUI amounts;

    public void SetearTexto()
    {
        int texttemp0 = 0;
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach (ScriptableIns ins in loadInsumos)
        {
            textos[texttemp0].text = ins.cantidad.ToString();
            images[texttemp0].sprite = ins._sprite;
            texttemp0++;
        }

        /* for (int i = 0; i < scriptableIns.Length; i++)
         {
             images[i].sprite = scriptableIns[i]._sprite;
             textos[i].text = scriptableIns[i].cantidad.ToString();
         }*/
    }

}
