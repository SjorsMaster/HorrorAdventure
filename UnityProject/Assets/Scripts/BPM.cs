using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour
{
    float Timer;
    [SerializeField]
    bool Beat;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.smoothDeltaTime;
        if(Timer >= 1)
        {
            Timer = 0;
        }
        if (Timer <= .1f || Timer >= .9f)
        {
            Beat = true;
        }
        else
        {
            Beat = false;
        }
    }
}
