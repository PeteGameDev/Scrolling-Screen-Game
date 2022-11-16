using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    public float damageAmount, attackRange;
    public LayerMask enemyLayer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
        if(Input.GetButtonDown("Fire2"))
        {
            MeleeAttack();
        }
    }

    void MeleeAttack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(firePoint.transform.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<BasicEnemy>().TakeDamage(damageAmount);
        }
    }

    IEnumerator Shoot()
    {
        GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(0.3f);
        GameObject clone2 = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(0.3f);
        GameObject clone3 = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(0.3f);
        Destroy(clone, 10f);
        Destroy(clone2, 10f);
        Destroy(clone3, 10f);
    }
}
