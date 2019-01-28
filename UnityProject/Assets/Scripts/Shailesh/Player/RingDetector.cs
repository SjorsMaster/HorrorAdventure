using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDetector : MonoBehaviour
{
    GameObject BPM;

    void Start()
    {
        BPM = GameObject.Find("BPMSync");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Spook")
        {
            BPM.GetComponent<BPM>().ToggleBeat(true);
            other.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(0.3f);
        }
        Debug.Log(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Spook")
        {
            BPM.GetComponent<BPM>().ToggleBeat(false);
            other.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(1f);
        }
    }
}
