using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooohhhPickupp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
           // NoDisc.Play();
        }
    }
}
