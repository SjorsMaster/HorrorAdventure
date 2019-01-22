using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BPM : MonoBehaviour
{
    [SerializeField]
    Image Syncer;
    AudioSource song;
    [SerializeField]
    float Offset, bpm = 1;
    float Timer;

    int buttonToPress = -1;

    [SerializeField]
    bool Beat;

    void Start()
    {        
        song = GameObject.Find("BPMSync").GetComponent<AudioSource>();
        Syncer = GameObject.Find("BPMSync").GetComponent<Image>();
        song.Play();
        Timer = Offset;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += (Time.smoothDeltaTime * bpm);
        if(Timer >= 1)
        {
            Timer = 0;
        }
        if (Timer <= .1f || Timer >= 0.9f)
        {
            RandomInput();
            Syncer.enabled = true;
            Beat = true;
        }
        else
        {
            buttonToPress = -1;
            Syncer.enabled = false;
            Beat = false;
        }
    }

    public void Beatpress(string buttonPressed)
    {
        if(int.Parse(buttonPressed) != (buttonToPress + 5))
        {
            Debug.Log("DOOD");
        }
        else
        {
            Debug.Log("win");
        }
    }

    void RandomInput()
    {
        if(buttonToPress == -1)
        {
            buttonToPress = Random.Range(0, 3);
            Debug.Log(buttonToPress);
        }
    }
}
