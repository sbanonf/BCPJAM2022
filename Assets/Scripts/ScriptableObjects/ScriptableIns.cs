using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Insumo",menuName = "Insumo")]
public class ScriptableIns : ScriptableObject
{
    public string nombre;
    public Sprite _sprite;
    public int cantidad;
    public int costo;
}
