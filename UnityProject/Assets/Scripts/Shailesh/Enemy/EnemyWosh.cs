using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWosh : MonoBehaviour
{
    [SerializeField]
    float speed;
    float timer = 0;
    int dir;
    GameObject player;
    bool attackPlayer;

    int health;

    Animator EnemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        health = 20;
        player = GameObject.Find("Player");
        dir = Random.Range(0,4);
        EnemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            dir = Random.Range(1, 5);
        }
        if(attackPlayer)
        {
            if (transform.position.x < player.transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        MoveEnemy(dir);
    }

    void MoveEnemy(int dir)
    {
        switch (dir)
        {
            case 1:
                //EnemyAnimator.SetInteger("Dir", 3);
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                break;
            case 2:
                //EnemyAnimator.SetInteger("Dir", 0);
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                break;
            case 3:
                transform.localScale = new Vector3(1, 1, 1);
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case 4:
                transform.localScale = new Vector3(-1, 1, 1);
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
        }
    }

    public void ChangeSpeed(float speedVar)
    {
        speed = speedVar;
    }

    public void Attack()
    {
        attackPlayer = true;
        EnemyAnimator.SetTrigger("Attack");
    }

    public void FloatAway()
    {
        EnemyAnimator.SetInteger("Dir", 2);
        Destroy(this.gameObject, 1.2f);
    }

    public void Idle()
    {
        EnemyAnimator.SetInteger("Dir", 0);
    }

    public void TakeHealth()
    {
        if(health > 0)
        {
            health = health - 1;
            Debug.Log(health);
        }

        if(health == 0)
        {
            FloatAway();
        }
    }
}
