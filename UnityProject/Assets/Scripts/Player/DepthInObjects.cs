using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthInObjects : MonoBehaviour
{

    private void Start()
    {
       // UpdateDepth();
    }

    public void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }

}
