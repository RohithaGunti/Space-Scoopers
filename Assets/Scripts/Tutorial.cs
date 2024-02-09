using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject silent;
    public GameObject welcome;
    public GameObject grab;
    public GameObject joystick;

    float tempx, tempy, tx, ty;

    //private float timer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        welcome.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            if(OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                welcome.SetActive(false);
                grab.SetActive(false);
                joystick.SetActive(true);
            }
        }
        if(OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) > 0f)
        {
            if(OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger, OVRInput.Controller.RTouch) > 0f)
            {
                SceneManager.LoadScene("Game");
            }
        }
        if(tempx!=tx || tempy!=ty)
        {
            welcome.SetActive(false);
            joystick.SetActive(false);
            grab.SetActive(true);
        }
    }
}
