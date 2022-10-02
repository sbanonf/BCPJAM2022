using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaSpawner : MonoBehaviour
{
    public GameObject baseGO;
    float randx;

    Vector2 whereToSpawn;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;

    public float speed;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randx = Random.Range(-20f, 20f);
            whereToSpawn = new Vector2(randx, transform.position.y);
            GameObject g = Instantiate(baseGO, whereToSpawn, Quaternion.identity);
            Rigidbody2D rb = g.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
        }
    }
}
