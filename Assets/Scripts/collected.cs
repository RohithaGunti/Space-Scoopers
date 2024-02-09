using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class collected : MonoBehaviour
{
    private TMP_Text collectednum;

    void Start(){
        
        collectednum = GetComponent<TMP_Text>();

    }
    void Update()
    {

        collectednum.text = Collect.collected.ToString("f0");
        //if(timer <=0 ){
        //    SceneManager.LoadScene("jwstt");
        //}
    }
}



