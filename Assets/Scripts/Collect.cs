using System.Collections;
using System.Collections.Generic;
//using System.Threading;
using UnityEngine;
using OVR;
using UnityEngine.SceneManagement;
//using System.Threading;
public class Collect : MonoBehaviour
{
    public GameObject voiles;
    public GameObject unittized;
    public GameObject structure;
    public GameObject pan02;
    public GameObject pan01;
    public GameObject mirrors;
    public GameObject mirroret;
   
    //public Transform gun;
    public static float collected = 0f;
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
        if(collision.gameObject.tag == "voiles") {
            Destroy(collision.gameObject);
           voiles.SetActive(true);
           collected++;
        }

        if(collision.gameObject.tag == "unittized") {
            Destroy(collision.gameObject);
           unittized.SetActive(true);
           collected++;
        }

        if(collision.gameObject.tag == "structure") {
            Destroy(collision.gameObject);
            collected++;
           structure.SetActive(true);
        }
    
        if(collision.gameObject.tag == "pan02") {
            Destroy(collision.gameObject);
            collected++;
            pan02.SetActive(true);
        }

        if(collision.gameObject.tag == "pan01") {
            Destroy(collision.gameObject);
            collected++;
            pan01.SetActive(true);
        }

        if(collision.gameObject.tag == "mirrors") {
            Destroy(collision.gameObject);
            collected++;
            mirrors.SetActive(true);
        }

        if(collision.gameObject.tag == "mirroret") {
            Destroy(collision.gameObject);
            collected++;
            mirroret.SetActive(true);
        }

    
        if(collected==7){
            SceneManager.LoadScene("Build");
        }
            //errormsg.SetActive(true);
            //yield return new WaitForSeconds(1);
            //errormsg.SetActive(false);
        }
    }

