using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class countdowntimer : MonoBehaviour
{
 
    public static float timer = 0f;
    private TMP_Text timerSeconds;

    void Start(){
        
        timerSeconds = GetComponent<TMP_Text>();

    }
    
    void Update()
    {
        timer += Time.deltaTime;
         timerSeconds.text = timer.ToString("f0");
        //if(timer <=0 ){
        //    SceneManager.LoadScene("jwstt");
        //}
    }
}



