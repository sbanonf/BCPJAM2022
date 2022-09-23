using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [Header("Variables Camara")]
    public GameObject player;
    public Camera _c;
    
    public GameObject[] Niveles;

    [Header("Variables Para generar Nivel")]
    public GameObject piso;
    public float tamaño;
    public float index;
    public int ZonaMuerta;

    private void Awake()
    {
        BoxCollider2D _bx = piso.GetComponent<BoxCollider2D>();
        tamaño = _bx.size.x * piso.transform.localScale.x;

    }
    private void Start()
    {

    }
    void Update()
    {
        if (player != null) {
            _c.transform.position = new Vector3(player.transform.position.x, _c.transform.position.y, _c.transform.position.z);
        }
        while (player != null && index < player.transform.position.x + ZonaMuerta) 
        { 
            int indice = Random.Range(0, Niveles.Length - 1);
            if (index < 0) { indice = Niveles.Length-1; } //Instanciaria siempre el ultimo.
            GameObject _nuevoPiso = Instantiate(Niveles[indice]);
            _nuevoPiso.transform.position = new Vector2(index+ tamaño/2, 0);
            index += tamaño;
            
        }
        

    }
}
