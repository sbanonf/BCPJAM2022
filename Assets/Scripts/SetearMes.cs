using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetearMes : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.SetearMes();
    }
}
