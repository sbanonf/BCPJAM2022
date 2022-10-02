using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroTexto : MonoBehaviour
{

    public Sprite[] sprites;
    public Image Imagen;
    public int index = 0;
    public Button botonder;
    public Button botonizq;
    public Button final;

    private void Update()
    {
        Debug.Log(index);
        if (index == 0)
        {
            botonizq.gameObject.SetActive(false);
            botonder.gameObject.SetActive(true);
            final.gameObject.SetActive(false);
        }
        else if (index == sprites.Length - 1)
        {

            botonder.gameObject.SetActive(false);
            final.gameObject.SetActive(true);
        }
        else if (index > 0)
        {
            botonder.gameObject.SetActive(true);
            botonizq.gameObject.SetActive(true);
            final.gameObject.SetActive(false);

        }        
        Imagen.sprite = sprites[index];
    }
    public void Avanzar() {
        AudioManager.instance.Play("click");
        index++;
    }

    public void Retrodecer()
    {
        AudioManager.instance.Play("click");
        index--;
    }

}
