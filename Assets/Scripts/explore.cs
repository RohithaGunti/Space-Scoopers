using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;

public class explore : MonoBehaviour
{
    public GameObject currentHitObject;

    public Material defaultMaterial;
    public Material highLightMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
        {
            Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*hit.distance,Color.red);
            var selectedObject = hit.transform;
            if(selectedObject != null)
            {
                Renderer selectedObjectRender = hit.transform.GetComponent<Renderer>();
                currentHitObject = hit.transform.gameObject;
                if(currentHitObject.tag == "carina" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("carina");
                }
                else if(currentHitObject.tag == "pillar" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("pillar");
                }
                else if(currentHitObject.tag == "neptune" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("neptune");
                }
                else if(currentHitObject.tag == "stephen" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("stephen");
                }
                else if(currentHitObject.tag == "ring" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("ring");
                }
                else if(currentHitObject.tag == "wasp" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("wasp");
                }
                else if(currentHitObject.tag == "earth" && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    SceneManager.LoadScene("Game");
                }
                
            }
        }
        
    }
}

