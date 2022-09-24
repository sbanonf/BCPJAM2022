using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public TextMeshProUGUI _cantidad;
    public GameObject cuy;
    public MoneyManager _moneyManager;
    public RandomCUy _CuyManager;
    int precio;
    private void Start()
    {
        precio = cuy.GetComponent<BuyerCuy>().cuy.precio;
        _moneyManager = GameObject.FindGameObjectWithTag("MoneyManager").GetComponent<MoneyManager>();
        _CuyManager = GameObject.FindGameObjectWithTag("CuyManager").GetComponent<RandomCUy>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Ondrop");
        if (!item) {
            item = Drag_Drop.itemDragging;
            string temp1 = item.GetComponent<Ins>().nombre.text;
            string temp2 = cuy.GetComponent<BuyerCuy>().insumo.nombre;
            if (temp1.Equals(temp2)) {
                Destroy(item);
                DisminuirCantidad();
            }
        }
    }
    private void Update()
    {
        if (item != null && item.transform.parent != transform) {
            item = null;
        }
        Validar();
    }
    public void DisminuirCantidad() {
        int temp3 = int.Parse(_cantidad.text);
        if (temp3 > 0)
        {
            temp3--;
            _cantidad.text = temp3.ToString();
            cuy.GetComponent<BuyerCuy>().insumo.cantidad--;
        }


    }
    public void Validar() {
        int temp3 = int.Parse(_cantidad.text);
        if ( temp3 == 0)
        {
            cuy.GetComponent<BuyerCuy>().InitializeUI();
            _moneyManager.AddMoney(precio);
            _CuyManager.InsTransform(this.transform);
            Destroy(cuy);

            
        }
    }
}
