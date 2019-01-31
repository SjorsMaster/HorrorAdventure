using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : GeneralFeatures

{
    Animator CharacterAnimation;
    BPM bpmscript;

    private void Start()
    {
        CharacterAnimation = GetComponent<Animator>();
    }

    public void Move(int dir)
    {
        UpdateDepth();
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
            transform.Translate((Vector2.left *2) * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 3)//right
        {
            Turn(1);
            transform.Translate((Vector2.right * 2) * Time.deltaTime);
            CharacterAnimation.SetInteger("Dir", 2);
        }
        if (dir == 4)//idle
        {
            CharacterAnimation.SetInteger("Dir", 0);
        }
    }
}
