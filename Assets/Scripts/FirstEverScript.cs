//These are library files, do not delete!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEverScript : MonoBehaviour
{
    //everything must go between this brackets. Like writing on paper

    int anInt; //whole numbers: 1, 2, 3, 4, 5
    float aFloat; //Decimal numbers: 0.1, 3.14, 9.81...
    string aString; //A sentence or collection of characters, such as this "a sentence or collection of letters"
    char aChar; //Single characters such as: A ! . O
    bool aBool; //A value which is only true or false


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This message should play at the start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This message should play at each frame");
    }



}
