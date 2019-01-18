using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator CharacterAnimation;
    bool turning;
    int direction;

    private void Start()
    {
        CharacterAnimation = GetComponent<Animator>();
    }

    private void Update()
    {
        if(turning == true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(direction, 1, 1), 0.2f);
            if(transform.localScale.x == direction)
            {
                turning = false;

            }

        }
    }

    public void Move(int dir)
    {

        if (dir == 0)//up
        {
            transform.Translate(Vector2.up * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 1);
        }
        if (dir == 1)//down
        {
            transform.Translate(Vector2.down * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 2)//left
        {
            Turn(-1);
            transform.Translate(Vector2.left * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 3)//right
        {
            Turn(1);
            transform.Translate(Vector2.right * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 4)//idle
        {
            CharacterAnimation.SetInteger("Dir", 0);
        }
    }

    void Turn(int dirx)
    {
        direction = dirx;
        turning = true;
    }
}
