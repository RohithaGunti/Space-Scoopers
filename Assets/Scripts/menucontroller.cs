using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
   public void StartBtn(){
     SceneManager.LoadScene("SampleScene");
   }

   public void videoBtn(){
     SceneManager.LoadScene("imgvideo");
   }
   public void menubtn(){
     SceneManager.LoadScene("main menu");
   }
   public void jwstbtn(){
     SceneManager.LoadScene("Build");
   }
   public void explorebtn(){
     SceneManager.LoadScene("Sun");
   }

}
