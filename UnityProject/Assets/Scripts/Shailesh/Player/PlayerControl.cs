using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(int dir)
    {
        if(dir == 0)
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }
        if (dir == 1)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
        if (dir == 2)
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
        if (dir == 3)
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
    }
}
