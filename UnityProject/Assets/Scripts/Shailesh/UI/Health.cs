using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    int health = 3;

    GameObject heart;

    public void TakeHealth()
    {
        heart = GameObject.Find("Hart" + health);


        if(health > 0)
        {
            Destroy(heart, 1.2f);
            health = health - 1;
            Debug.Log(health);
        }
    }
}
