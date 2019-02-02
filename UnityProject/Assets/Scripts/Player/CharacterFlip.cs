using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlip : MonoBehaviour
{

    bool turning;
    int direction;

    private void Update()
    {
        if (turning == true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(direction, 1, 1), 0.2f);
            if (transform.localScale.x == direction)
            {
                turning = false;

            }

        }
    }

    public void Turn(int dirx)
    {
        direction = dirx;
        turning = true;
    }
}
