﻿using UnityEngine;
using System.IO;

public class InputManagerGame : MonoBehaviour
{
    string[] keys = File.ReadAllLines("Assets/Resources/keys.txt");
    GameObject Player, Enemy;
    enum Dir { up, down, left, right, idle, Act1, Act2, Act3 };
    
    private PlayerControl anotherScript;

    private void Start()
    {
        Player = GameObject.Find("Player");
        anotherScript = Player.GetComponent<PlayerControl>();
    }

    void Update()//beatmannager//KeyPress
    {
        if(Input.GetKey(keys[(int)Dir.up]))
        {
            anotherScript.Move((int)Dir.up);
        }
        if (Input.GetKey(keys[(int)Dir.down]))
        {
            anotherScript.Move((int)Dir.down);
        }
        if (Input.GetKey(keys[(int)Dir.left]))
        {
            anotherScript.Move((int)Dir.left);
        }
        if (Input.GetKey(keys[(int)Dir.right]))
        {
            anotherScript.Move((int)Dir.right);
        }
        if (Input.GetKey(keys[(int)Dir.Act1]))
        {
            Enemy.GetComponent<BeatManager>().KeyPress();
        }
        if (Input.GetKey(keys[(int)Dir.Act2]))
        {
            Enemy.GetComponent<BeatManager>().KeyPress();
        }
        if (Input.GetKey(keys[(int)Dir.Act3]))
        {
            Enemy.GetComponent<BeatManager>().KeyPress();
        }
        else
        {
            anotherScript.Move((int)Dir.idle);
        }
    }

    public void GetEnemy(GameObject Target)
    {
        Enemy = Target;
    }


}
                                                                                