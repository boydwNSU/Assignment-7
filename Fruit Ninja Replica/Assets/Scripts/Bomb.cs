using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject hitBombPrefab;
    float startForce = 15f;

    Rigidbody2D rb;

    public static int bombsHit = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject hitBomb = Instantiate(hitBombPrefab, transform.position, rotation);
            Destroy(hitBomb, 3f);
            Destroy(gameObject);

            bombsHit++;
        }
    }
}
