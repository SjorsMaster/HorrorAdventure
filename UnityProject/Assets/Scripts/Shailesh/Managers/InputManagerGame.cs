using UnityEngine;
using System.IO;

public class InputManagerGame : MonoBehaviour
{
    string[] keys = File.ReadAllLines("Assets/Resources/keys.txt");
    GameObject kaas;
    enum Dir { up, down, left, right };
    
    private PlayerControl anotherScript;

    private void Start()
    {
        kaas = GameObject.Find("Player");
        anotherScript = kaas.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keys[(int)Dir.up]))
        {
            anotherScript.Move((int)Dir.up);
        }
        if (Input.GetKey(keys[(int)Dir.down]))
        {
            anotherScript.Move((int)Dir.down);
        }
        if (Input.GetKey(keys[(int)Dir.left]))
        {
            anotherScript.Move((int)Dir.left);
        }
        if (Input.GetKey(keys[(int)Dir.right]))
        {
            anotherScript.Move((int)Dir.right);
        }
    }


}
