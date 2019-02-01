using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RingDetector : MonoBehaviour
{
    bool seen;
    GameObject BPM;
    GameObject ScreenUI;
    readonly string tagName = "Monster";
    GameObject topBar, downBar;
    GameObject enemyInRing;
    bool inBattle = false;
    int counter;

    void Start()
    {
        BPM = GameObject.Find("BPMSync");
        ScreenUI = GameObject.Find("Canvas");
        topBar = GameObject.FindGameObjectWithTag("UpBar");
        downBar = GameObject.FindGameObjectWithTag("DownBar");
    }

    private void Update()
    {
        if (inBattle && counter < 60)
        {
            topBar.transform.Translate(0, 40 * Time.deltaTime, 0);
            downBar.transform.Translate(0, -40 * Time.deltaTime, 0);
            counter++;
        }
        else if (!inBattle && counter > 0)
        {
            topBar.transform.Translate(0, -40 * Time.deltaTime, 0);
            downBar.transform.Translate(0, 40 * Time.deltaTime, 0);
            counter--;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!seen)
        {
            if (other.gameObject.tag == tagName)
            {
                enemyInRing = other.gameObject;
                Battle(other.gameObject, true, 0.3f);
                inBattle = true;
            }
        }
        if (other.gameObject.name == "Exit")
        {
            SceneManager.LoadScene("nocd");
        }
    }

    public void EnemyInRingTakeHealth()
    {
        enemyInRing.GetComponent<EnemyWosh>().TakeHealth();
    }

    public void TakeLifePlayer()
    {
        ScreenUI.gameObject.GetComponent<Health>().TakeHealth();
    }

    public void EnemyInRingAttack()
    {
        if (enemyInRing != null)
        {
            enemyInRing.GetComponent<EnemyWosh>().Attack();
        }
        else
        {
            ToggleOffMonster(enemyInRing);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (seen)
        {
            if (other.gameObject.tag == tagName)
            {
                ToggleOffMonster(enemyInRing);
            }
        }
    }
    private void Battle(GameObject go, bool toggleSeen, float cSpeed)
    {
        BPM.GetComponent<BPM>().ToggleBeat(toggleSeen);
        go.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(cSpeed);
        seen = toggleSeen;
    }

    void ToggleOffMonster(GameObject other)
    {
        other.gameObject.GetComponent<EnemyWosh>().Idle();
        Battle(other.gameObject, false, 1f);
        inBattle = false;
    }
}
