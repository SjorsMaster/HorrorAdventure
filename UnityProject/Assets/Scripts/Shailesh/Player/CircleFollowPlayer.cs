using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class CircleFollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject centerPlayer;

    void Update()
    {
        transform.position = new Vector3(centerPlayer.transform.position.x, centerPlayer.transform.position.y, transform.position.z);
    }
}
