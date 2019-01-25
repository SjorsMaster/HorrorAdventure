using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCont : MonoBehaviour
{
    float Timer, x, y;
    [SerializeField]
    void Update()
    {
        MoveDir();
        Timer += Time.deltaTime;
        if(Timer > 4)
        {
            Timer = 0;
            CalculateDirection();
        }
    }

    void MoveDir()
    {
        transform.Translate(new Vector3(x, y, transform.position.z));
    }

    void CalculateDirection()
    {
        x = Random.Range(1,10);
        y = Random.Range(1,10);
    }
}
