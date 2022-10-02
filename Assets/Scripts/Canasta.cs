using UnityEngine;

public class Canasta : MonoBehaviour
{
    private void OnEnable()
    {
        TimeManager.instance.sepuede = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Insumo")
        {
            InsumoData insumoData = collision.gameObject.GetComponent<InsumoData>();
            ItemManager.itemManagerInstance.showValue(insumoData, transform);
            Destroy(collision.gameObject);
            AudioManager.instance.Play("objeto");
            insumoData.insumo.cantidad++;
            InventarioManager.instance.AñadirIngreso();
            MoneyManager.instance.PayMoney(insumoData.insumo.costo);
        }
        if (collision.tag == "Hormiga")
        {
            Destroy(collision.gameObject);
            ItemManager.itemManagerInstance.showValue(-5, transform);
            AudioManager.instance.Play("objeto");
            MoneyManager.instance.PayMoney(-5);
        }
    }
}
