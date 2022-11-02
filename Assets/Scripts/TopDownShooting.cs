using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
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
