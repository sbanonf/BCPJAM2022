using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoreManager : MonoBehaviour
{
    public GameObject _insumo;
    public int inventariomax;
    public int _c;

    private void OnLevelWasLoaded()
    {
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach (ScriptableIns ins in loadInsumos) {
            Debug.Log(_c);
                for (int i = 0; i < ins.cantidad; i++)
                {
                    if (_c < inventariomax) {
                        Ins newInsumo = Instantiate(_insumo, transform).GetComponent<Ins>();
                        newInsumo.insumo = ins;
                        _c++;
                    }
                    
                }
        }
    }

}
