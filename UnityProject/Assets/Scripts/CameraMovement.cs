using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject Target;
    float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
