using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GeneralFeatures : MonoBehaviour
{
    [SerializeField]
    GameObject Target;
    [SerializeField]
    bool turning, KeepCheckingDistance;
    [SerializeField]
    float direction;

    private void Start()
    {
        direction = transform.localScale.x;
        transform.localScale = new Vector3(direction, 1, 1);
        UpdateDepth();
    }

    private void Update()
    {
        if (turning == true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(direction, 1, 1), 0.2f);
            if (transform.localScale.x == direction)
            {
                turning = false;
            }
        }
        if (KeepCheckingDistance)
        {
            UpdateDepth();
        }
    }

    public void Turn(int dirx)
    {
        direction = dirx;
        turning = true;
    }

    public void UpdateDepth()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Target.transform.position.y);
    }
}
