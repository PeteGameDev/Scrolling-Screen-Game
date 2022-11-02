using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownBullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Target"))
        {
            Destroy(other.gameObject);
        }
    }
}
