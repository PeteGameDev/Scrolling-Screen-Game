using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject purpleDoor;

    void Start()
    {
        purpleDoor = GameObject.Find("Purple Door");
    }


    void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Health Item"))
        {
            Debug.Log("Health added");
            gameObject.GetComponent<PlayerHealth>().playerHealth += 10f;
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Door") && Input.GetKeyDown(KeyCode.E)){
            Debug.Log("Opening Door");
            Destroy(purpleDoor);
        }
    }
}
