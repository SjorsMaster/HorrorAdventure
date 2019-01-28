using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWosh : MonoBehaviour
{
    [SerializeField]
    float speed;
    float timer = 0;
    int dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = Random.Range(0,4);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 2)
        {
            timer = 0;
            dir = Random.Range(1,5);
            Debug.Log(dir);
        }
        MoveEnemy(dir);
    }

    void MoveEnemy(int dir)
    {
        switch (dir)
        {
            case 1:
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                break;
            case 2:
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                break;
            case 3:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case 4:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
        }
    }

    public void ChangeSpeed(float speedVar)
    {
        speed = speedVar;
    }
}
