﻿using System.Collections;
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


    int buttonToPress = -1;

    [SerializeField]
    bool Beat, Active = false;

    void Start()
    {
        Ring = GameObject.Find("HitRing");
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
                Beat = false;
                timtim = 0;
            }

            if(Beat)
            {
                Syncer.enabled = true;
                if (Input.GetKeyDown("z"))
                {
                    Ring.GetComponent<RingDetector>().EnemyInRingTakeHealth();
                }
            }
            else
            {
                Syncer.enabled = false;
                if (Input.GetKeyDown("z"))
                {
                    Ring.GetComponent<RingDetector>().TakeLifePlayer();

                    Ring.GetComponent<RingDetector>().EnemyInRingAttack();
                }
            }


            EncounterMusic.volume = 1;
            /*if ((Timer <= .1f || Timer >= 0.9f) && EncounterMusic.volume == 1)
            {
                //RandomInput();
                //song.volume = 0;
                Syncer.enabled = true;
                Beat = true;
            }
            else
            {
                buttonToPress = -1;
                Syncer.enabled = false;
                Beat = false;
            }
            */
         
        }
        else
        {
            //song.volume = 1;
            EncounterMusic.volume = 0;
        }



      
    }

    public void Beatpress(string buttonPressed)
    {
        if(/*(int.Parse(buttonPressed) != (buttonToPress + 5)) && */!Beat)
        {
            Debug.Log("DOOD");
        }
        else
        {
            Debug.Log("win");
        }
    }
    /*
    void RandomInput()
    {
        if(buttonToPress == -1)
        {
            buttonToPress = Random.Range(0, 3);
            Debug.Log(buttonToPress);
        }
    }*/

    public void ToggleBeat(bool State)
    {
        Active = State;
        Camera.GetComponent<CameraMovement>().ToggleZoom(State);
    }
}
