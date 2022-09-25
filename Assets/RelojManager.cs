using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelojManager : MonoBehaviour
{
    public Sprite[] _sprites;
    public Image reloj;
    private void OnEnable()
    {
        int temp = TimeManager.instance.stage;
        reloj.sprite = _sprites[temp];
    }
}
