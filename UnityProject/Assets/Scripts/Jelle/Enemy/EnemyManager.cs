using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    bool moveUp = true;
    float idleTimer;
    [SerializeField]
    float idleCap = 2;
    int stepCounter;
    int stepCounterCap = 180;
    [SerializeField]
    float stepSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp)
        {
            idleTimer += Time.deltaTime;
            if (idleTimer > idleCap)
            {
                transform.Translate(0, stepSpeed * Time.deltaTime, 0);
                stepCounter++;
                if (stepCounter >= stepCounterCap)
                {
                    idleCap = Random.Range(0.0f,2.0f);
                    moveUp = false;
                    stepCounter = 0;
                    idleTimer = 0;
                }
            }
        }
        else
        {
            idleTimer += Time.deltaTime;
            if (idleTimer > idleCap)
            {
                transform.Translate(0, -stepSpeed * Time.deltaTime, 0);
                stepCounter++;
                if (stepCounter >= stepCounterCap)
                {
                    idleCap = Random.Range(0.0f, 2.0f);
                    moveUp = true;
                    stepCounter = 0;
                    idleTimer = 0;
                }
            }
        }
    }
}
