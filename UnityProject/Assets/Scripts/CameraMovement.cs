using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject Target;
    Camera cam;
    [SerializeField]
    bool zoom;
    float Speed = 0;

    void Start()
    {
        cam = GetComponent<Camera>();
        Target = GameObject.Find("Player");
    }

    public void ToggleZoom(bool State)
    {
        zoom = State;
    }

    void Update()
    {

        BattleZoomer();
        SmoothMover();

    }

    void BattleZoomer()
    {
        float maxSize = 6.5f,
              minSize = 3.5f,
              stepSize = 0.1f;

        if (zoom && cam.orthographicSize > minSize)
        {
            cam.orthographicSize -= stepSize;
        }

        if (!zoom && cam.orthographicSize < maxSize)
        {
            cam.orthographicSize += stepSize;
        }
    }


    void SmoothMover()
    {

        if ((transform.position.x.ToString("n2") != Target.transform.position.x.ToString("n2")) || (transform.position.y.ToString("n2") != Target.transform.position.y.ToString("n2")))
        {
            Speed += 0.01f / 100;
            transform.position = Vector3.Lerp(transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y, -10), Speed);
        }
        else
        {
            if (Speed > 0.0001)
            {
                Speed -= 0.01f * 10;
            }
        }
        if (Speed > 0.1f)
        {
            Speed = 0.1f;
        }
        if (Speed < 0.0001)
        {
            Speed = 0.0001f;
        }
    }
    
}
