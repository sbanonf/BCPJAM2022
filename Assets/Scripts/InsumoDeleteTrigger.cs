using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsumoDeleteTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Insumo")
        {
            Destroy(collision.gameObject);
        }
    }
}
