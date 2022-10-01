using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreManager : MonoBehaviour
{

    public StoreManager instance;
    public int cantidadvendida;
    public TextMeshProUGUI[] textos;
    

    private void OnLevelWasLoaded()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        SetearTextos();

    }
    public void SetearTextos() {
        int texttemp0= 0;
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach (ScriptableIns ins in loadInsumos)
        {
            textos[texttemp0].text = ins.cantidad.ToString();
            texttemp0++;
        }
        
    }
}
