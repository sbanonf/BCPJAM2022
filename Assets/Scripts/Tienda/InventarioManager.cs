using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioManager : MonoBehaviour
{
    public static InventarioManager instance;
    public int ingresos;
    public int Egresos;

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

    public void A�adirIngreso() {
        ingresos++;
    }

    public void A�adirEgreso() {
        Egresos++;
    }
}
