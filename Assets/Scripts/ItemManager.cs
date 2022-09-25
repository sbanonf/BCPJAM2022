using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class ItemManager : MonoBehaviour
{
    public static ItemManager itemManagerInstance;

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

    public GameObject floatingText;
    public void showValue(InsumoData insumoData, Transform transformCanasta)
    {
        var t = Instantiate(floatingText, transformCanasta.position, Quaternion.identity);
        t.GetComponent<TextMeshPro>().text = "-/s." + insumoData.insumo.costo;
    }
}
