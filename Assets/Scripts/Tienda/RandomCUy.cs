using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCUy : MonoBehaviour
{
    public GameObject[] casas;
    public GameObject cuyInst;
    private GameObject cuyverdad;
    List<ScriptableCuy> Cuyes = new List<ScriptableCuy>();
    List<ScriptableIns> Insumos = new List<ScriptableIns>();

    private ScriptableIns[] _si;
    private void Awake()
    {
        var loadInsumos = Resources.LoadAll("Insumos", typeof(ScriptableIns));
        foreach(var insumo in loadInsumos){
            Insumos.Add((ScriptableIns)insumo);
        }
        var loadCuys = Resources.LoadAll("Cuys", typeof(ScriptableCuy));
        foreach(var cuys in loadCuys){
            Cuyes.Add((ScriptableCuy)cuys);
        }
    }
    private void Start()
    {
        for (int i = 0; i < casas.Length; i++) {
            Instanciar(i);
        }
    }
    void Instanciar(int index) {
        int auxc = Random.Range(0, Cuyes.Count);
        int auxi = Random.Range(0, Insumos.Count);
        cuyverdad = cuyInst.GetComponent<Slot>().cuy;
        cuyverdad.GetComponent<BuyerCuy>().cuy = Cuyes[auxc];
        cuyverdad.GetComponent<BuyerCuy>().insumo = Insumos[auxi];
        cuyInst.GetComponent<Slot>().cuy = cuyverdad;
        Instantiate(cuyInst, casas[index].transform);       
    }
    public void InsTransform(Transform position) {
        Debug.Log("Hola");
        int auxc = Random.Range(0, Cuyes.Count);
        int auxi = Random.Range(0, Insumos.Count);
        cuyverdad = cuyInst.GetComponent<Slot>().cuy;
        cuyverdad.GetComponent<BuyerCuy>().cuy = Cuyes[auxc];
        cuyverdad.GetComponent<BuyerCuy>().insumo = Insumos[auxi];
        cuyInst.GetComponent<Slot>().cuy = cuyverdad;
        Instantiate(cuyInst, position);

    }
}
