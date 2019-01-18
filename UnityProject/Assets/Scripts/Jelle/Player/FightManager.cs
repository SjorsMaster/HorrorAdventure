using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{   [SerializeField]
    readonly float detectionRange = 2;
    readonly string tagName = "Monster";
    GameObject[] monsterArray;
    float distanceToMonsterX;
    float distanceToMonsterY;
    // Start is called before the first frame update
    void Start()
    {
        monsterArray = GameObject.FindGameObjectsWithTag(tagName);
    }

    // Update is called once per frame
    void Update()
    {
        CheckForMonsters();
    }

    void CheckForMonsters()
    {
        monsterArray = GameObject.FindGameObjectsWithTag(tagName);
        for (int i = 0; i < monsterArray.Length; i++)
        {
            distanceToMonsterX =  monsterArray[i].transform.position.x - transform.position.x;
            distanceToMonsterY =  monsterArray[i].transform.position.y - transform.position.y;
            if (distanceToMonsterX < detectionRange && distanceToMonsterY < detectionRange)
            {
                Debug.Log("Kanker, er is een monster in de buurt");
            }
        }
    }
}
