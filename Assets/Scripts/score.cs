using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class score : MonoBehaviour
{
    private TMP_Text scorenum;

    void Start(){
        
        scorenum = GetComponent<TMP_Text>();

    }
    void Update()
    {

        scorenum.text = countdowntimer.timer.ToString("f0");
        //if(timer <=0 ){
        //    SceneManager.LoadScene("jwstt");
        //}
    }

   
}



