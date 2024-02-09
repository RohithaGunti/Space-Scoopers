using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttonfunc : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartBtn(){
     SceneManager.LoadScene("Game");
   }
   public void TutorialBtn(){
     SceneManager.LoadScene("Tutorial");
   }
   public void GameBtn(){
     SceneManager.LoadScene("sky");
   }
   public void QuizBtn(){
     SceneManager.LoadScene("quiz");
   }

   
}
