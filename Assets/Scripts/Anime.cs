using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Anime : MonoBehaviour
{
  public GameObject Cam;
  public GameObject onemove;
  public Animator ani;

  void Start () 
  {
      //Text = Text.GetComponent<Button> ();
      ani.enabled = false;
      //yourcanvas.enabled = true;
  }
    
  public void Press() 
        
  {
      //Text.enabled = true;
      //AudioSource.PlayClipAtPoint(sound, transform.position);
      //ani.enabled = true;
  }

  private void ExecuteTrigger(string trigger)
  {
    if(Cam != null)
    {
      var a = Cam.GetComponent<Animator>();
      if(a != null)
      {
        a.SetTrigger(trigger);
      }
    }
  }
  
  public void OnOneScreen(){
    ani.enabled = true;
    //onemove.SetActive(true);
  }
  
   public void QuizBtn(){
     SceneManager.LoadScene("quiz");
   }
}
