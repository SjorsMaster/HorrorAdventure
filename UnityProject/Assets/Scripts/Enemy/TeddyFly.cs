using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyFly : MonoBehaviour
{
    [SerializeField]
    GameObject TargetObject;
    Vector3 Target;
    bool notAtGoal = true;
    private void Start()
    {
        Target = TargetObject.transform.position;
    }
    void Update()
    {
        if (notAtGoal)
        {
            transform.position = Vector3.Lerp(transform.position, Target, 0.1f / 45);
        }
        if(transform.position == Target)
        {
            notAtGoal = false;
        }
    }
}
