using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCamera : MonoBehaviour
{
    [SerializeField]
    float maxSize = 7;
    [SerializeField]
    float minSize = 3;
    [SerializeField]
    float stepSize = 0.1f;
    bool zoom = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var cam = GetComponent<Camera>();
        if (zoom && cam.orthographicSize > minSize)
        {
            cam.orthographicSize -= stepSize;
        }

        if (!zoom && cam.orthographicSize < maxSize)
        {
            cam.orthographicSize += stepSize;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            BattleZoom();
        }


    }

    void BattleZoom()
    {
        zoom = !zoom;
    }
}
