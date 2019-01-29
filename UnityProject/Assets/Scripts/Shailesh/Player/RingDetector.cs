using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingDetector : MonoBehaviour
{
    bool seen;
    GameObject BPM;
    readonly string tagName = "Monster";

    void Start()
    {
        BPM = GameObject.Find("BPMSync");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!seen)
        {
            if (other.gameObject.tag == tagName)
            {
                Battle(other.gameObject, true, 0.3f);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (seen)
        {
            if (other.gameObject.tag == tagName)
            {
                Battle(other.gameObject, false, 1f);
            }
        }
    }
    private void Battle(GameObject go, bool toggleSeen, float cSpeed)
    {
        BPM.GetComponent<BPM>().ToggleBeat(toggleSeen);
        go.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(cSpeed);
        seen = toggleSeen;
    }
}
