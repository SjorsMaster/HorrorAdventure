using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{   [SerializeField]
    RawImage blackPlane;
    float minTransparency = 0;
    float maxTransparency = 1;
    bool fadeOut = false;
    float currentTransparency = 0;
    // Start is called before the first frame update
    void Start()
    {
        blackPlane = GetComponent<RawImage>();
        blackPlane.color = new Color(0, 0, 0, currentTransparency);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeOut && currentTransparency < maxTransparency)
        {
            currentTransparency += 0.01f;
            blackPlane.color = new Color(0, 0, 0, currentTransparency);
        }

        if (!fadeOut && currentTransparency > minTransparency)
        {
            currentTransparency -= 0.01f;
            blackPlane.color = new Color(0, 0, 0, currentTransparency);
        }


        if (Input.GetKeyDown(KeyCode.O))
        {
            ToggleFadeOut();
        }
    }

    void ToggleFadeOut()
    {
        fadeOut = !fadeOut;
    }

}
