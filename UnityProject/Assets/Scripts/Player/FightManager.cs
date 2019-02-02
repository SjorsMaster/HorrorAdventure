using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{   [SerializeField]
    readonly float detectionRange = 3;
    readonly string tagName = "Monster";
    private readonly string cameraName = "Main Camera";
    GameObject[] monsterArray;
    float distanceToMonsterX;
    float distanceToMonsterY;
    private BattleCamera camReference;
    private bool initiateOnce = true;
    // Start is called before the first frame update
    void Start()
    {
        monsterArray = GameObject.FindGameObjectsWithTag(tagName);
        camReference = GameObject.Find(cameraName).GetComponent<BattleCamera>();
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
            if (distanceToMonsterX < detectionRange && distanceToMonsterY < detectionRange && initiateOnce)
            {
                InitiateBattle();
            }
            else
            {
                camReference.BattleZoomOut();
            }

        }
    }

	void InitiateBattle() {
        camReference.BattleZoomIn();
	}
}
