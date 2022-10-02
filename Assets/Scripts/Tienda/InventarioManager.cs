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

    public void AñadirIngreso() {
        ingresos++;
    }

    public void AñadirEgreso() {
        Egresos++;
    }
}
