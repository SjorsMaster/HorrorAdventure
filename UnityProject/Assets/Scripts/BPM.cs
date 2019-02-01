using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BPM : MonoBehaviour
{
    [SerializeField]
    AudioSource EncounterMusic;

    GameObject Camera;

    [SerializeField]
    Image Syncer;
    AudioSource song;
    [SerializeField]
    float Offset, bpm = 1;
    float Timer;
    float timtim;
    float echtebpm;

    GameObject Ring;
    RingDetector ringscript;


    int buttonToPress = -1;

    [SerializeField]
    bool Beat, Active = false, Got = false, LifeTaken = false;

    void Start()
    {
        Ring = GameObject.Find("HitRing");
        ringscript = Ring.GetComponent<RingDetector>();
        timtim = 0;
        Camera = GameObject.Find("Camera");
        EncounterMusic = GameObject.Find("HitRing").GetComponent<AudioSource>();
        song = GameObject.Find("BPMSync").GetComponent<AudioSource>();
        Syncer = GameObject.Find("BPMSync").GetComponent<Image>();
        song.Play();
        EncounterMusic.volume = 0;
        EncounterMusic.Play();
        Timer = Offset;
        echtebpm = EncounterMusic.clip.length / 16;
    }

    private void FixedUpdate()
    {
        Timer += (Time.deltaTime * bpm);
        if (Timer >= 1)
        {
            Timer = 0;
        }
    }

    void Update()
    {
        if (Active)
        {

            timtim += Time.deltaTime;
            if (timtim >= echtebpm - 0.6f && timtim <= echtebpm)
            {
                Beat = true;
            }
            if (timtim >= echtebpm)
            {
                LifeTaken = false;

                Got = false;
                Beat = false;
                timtim = 0;
            }

            if(Beat)
            {
                Syncer.enabled = true;
                if (Input.GetKeyDown("z"))
                {
                    Got = true;
                    ringscript.EnemyInRingTakeHealth();
                }
            }
            else
            {
                Syncer.enabled = false;
                if (!Got && !Beat && !LifeTaken)
                {
                    LifeTaken = true;
                    ringscript.TakeLifePlayer();

                    ringscript.EnemyInRingAttack();
                }
            }


            EncounterMusic.volume = 1;
          
         
        }
        else
        {
            EncounterMusic.volume = 0;
        }



      
    }

    public void ToggleBeat(bool State)
    {
        Active = State;
        Camera.GetComponent<CameraMovement>().ToggleZoom(State);
    }
}
