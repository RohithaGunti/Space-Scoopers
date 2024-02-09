using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;

public class Build : MonoBehaviour
{
    public GameObject jwst;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "all")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            jwst.SetActive(true);
             SceneManager.LoadScene("Sun");
        }
    
        //if(collision.gameObject.tag == "2instruments")
        //{
            //Destroy(collision.gameObject);
            //mir.SetActive(true);
        //}

        /*if(collision.gameObject.tag == "2secmirror")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "sunshade")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "p1")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "p2")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "struct")
        {
            Destroy(collision.gameObject);
        }*/


    }
}

