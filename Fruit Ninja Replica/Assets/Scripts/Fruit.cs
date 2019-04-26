using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	float startForce = 30f;

    public static int cutFruit = 0;
    public static int unharmedFruit = 0;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Settings.fruitSpeed, ForceMode2D.Impulse);
    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
            Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
            cutFruit++;
		}
        if (col.tag == "outOfBounds")
        {
            Debug.Log("Miss");
            unharmedFruit++;
        }

    }
    

}
