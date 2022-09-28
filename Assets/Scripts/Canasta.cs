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
            insumoData.insumo.cantidad++;
            MoneyManager.instance.PayMoney(insumoData.insumo.costo);
        }
    }
}
