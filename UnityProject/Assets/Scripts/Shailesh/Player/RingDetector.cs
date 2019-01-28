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
        }
        Debug.Log(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Spook")
        {
            BPM.GetComponent<BPM>().ToggleBeat(false);
        }
    }
}
