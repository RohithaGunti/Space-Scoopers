using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Titlechange : MonoBehaviour
{
 
    public float timer = 1.3f;

    public void Update(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
           SceneManager.LoadScene("Start");
        }
    }

    public void changescene(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
            SceneManager.LoadScene("Start");
         }
    }
}