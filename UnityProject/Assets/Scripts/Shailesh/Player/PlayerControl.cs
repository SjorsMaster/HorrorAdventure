using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator CharacterAnimation;

    private void Start()
    {
        CharacterAnimation = GetComponent<Animator>();
    }

    public void Move(int dir)
    {
        if (dir == 4)//idle
        {
            CharacterAnimation.SetInteger("Dir", 0);
        }
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
            transform.Translate(Vector2.left * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 3)//right
        {
            transform.Translate(Vector2.right * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
    }
}
