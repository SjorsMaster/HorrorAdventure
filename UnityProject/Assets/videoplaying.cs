using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class videoplaying : MonoBehaviour
{
    void Update()
    {
        var videoPlayer = GameObject.Find("GameObject").GetComponent<UnityEngine.Video.VideoPlayer>();

        if (!videoPlayer.isPlaying)
        {
            Application.Quit();
            EditorApplication.Exit(0);
        }
    }
}
