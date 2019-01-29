using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingDetector : MonoBehaviour
{
    bool seen;
    GameObject BPM;

    void Start()
    {
        BPM = GameObject.Find("BPMSync");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!seen)
        {
            if (other.gameObject.name == "Spook")
            {
                BPM.GetComponent<BPM>().ToggleBeat(true);
                other.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(0.3f);
                seen = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (seen)
        {
            if (other.gameObject.name == "Spook")
            {
                BPM.GetComponent<BPM>().ToggleBeat(false);
                other.gameObject.GetComponent<EnemyWosh>().ChangeSpeed(1f);
                seen = false;
            }
        }
    }
}
