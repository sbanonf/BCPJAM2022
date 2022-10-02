using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoManager : MonoBehaviour
{
    public GameObject[] prefabs;

    private void OnLevelWasLoaded()
    {
        Instanciar();
    }

    void Instanciar() {
        int index = Random.Range(0, prefabs.Length);
        Debug.Log(index);
        Debug.Log("longitud" + prefabs.Length);
        if (TimeManager.instance.stage == 0 && GameManager.Instance._mes > 1) {
            AudioManager.instance.Play("evento");
            Instantiate(prefabs[index], transform);
        }    
    }


}
