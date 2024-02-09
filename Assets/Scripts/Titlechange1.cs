using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Titlechange1 : MonoBehaviour
{
 
    public float timer = 8f;

    public void Update(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
           SceneManager.LoadScene("Ufo");
        }
    }

    public void changescene(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
            SceneManager.LoadScene("Ufo");
         }
    }
}