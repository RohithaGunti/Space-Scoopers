using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene("Sun");
        }
    }
}
