using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public BuyerCuy cuy;
    public float Tiempolimite;
    public Slider _slider;
    public GameObject cuypadre;
    public RandomCUy cm;
    private void Awake()
    {
        cm = GameObject.FindGameObjectWithTag("CuyManager").GetComponent<RandomCUy>();
        _slider = this.GetComponent<Slider>();
        Tiempolimite = cuy.cuy.tiempolimite;
        _slider.maxValue = Tiempolimite;
    }
    private void Update()
    {   Tiempolimite -= Time.deltaTime;
        _slider.value = Tiempolimite;

        if (_slider.value == _slider.minValue) {
            cm.InsTransform(cuypadre.gameObject.transform.parent.transform);
            Destroy(cuypadre);
            
        }
    }
}
