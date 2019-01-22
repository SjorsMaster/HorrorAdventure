using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVidState : MonoBehaviour
{
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        if (!videoPlayer.isPlaying)
        {
            EndReached();
        }
    }

    void EndReached()
    {
        Application.Quit();
        Debug.Log("couldn't quit");
    }
}
