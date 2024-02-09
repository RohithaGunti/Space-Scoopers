using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Titlechange2 : MonoBehaviour
{
 
    public float timer = 14.3f;

    public void Update(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
           SceneManager.LoadScene("MazeGame");
        }
    }

    public void changescene(){
        timer -= Time.deltaTime;
        if(timer <=0 ){
            SceneManager.LoadScene("MazeGame");
         }
    }
}