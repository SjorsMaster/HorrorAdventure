using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject Target;
    [SerializeField]
    float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
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
        if(Speed > 0.1f)
        {
            Speed = 0.1f;
        }
        if(Speed < 0.0001)
        {
            Speed = 0.0001f;
        }
    }
}
