using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Health Item") && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Health added");
            gameObject.GetComponent<PlayerHealth>().playerHealth += 10f;
            Destroy(other.gameObject);
        }
    }
}
