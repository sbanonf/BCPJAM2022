using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjects : MonoBehaviour
{
    public ScriptableIns[] scriptable;
    public GameObject baseGO;
    float randx;

    Vector2 whereToSpawn;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;

    public float speed;

    public int specialProbability;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            int randomNumber = Random.Range(0, 1000);//En lo habitual sería de 0 a 100 pero prefiero de 0 a 1000
            if (specialProbability > randomNumber)
            {
                /*nextSpawn = Time.time + spawnRate;
                randx = Random.Range(-10f, 10f);
                whereToSpawn = new Vector2(randx, transform.position.y);
                GameObject g = Instantiate(specialObjects[Random.Range(0, specialObjects.Length)], whereToSpawn, Quaternion.identity);
                Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * speed, ForceMode2D.Impulse);*/
            }
            else
            {
                nextSpawn = Time.time + spawnRate;
                randx = Random.Range(-20f, 20f);
                whereToSpawn = new Vector2(randx, transform.position.y);
                GetProperties();
                GameObject g = Instantiate(baseGO, whereToSpawn, Quaternion.identity);
                Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
            }
        }
    }

    void GetProperties()
    {
        int rand = Random.Range(0, scriptable.Length );
        baseGO.GetComponent<SpriteRenderer>().sprite = scriptable[rand]._sprite;
        baseGO.GetComponent<InsumoData>().insumo = scriptable[rand];
    }
}
