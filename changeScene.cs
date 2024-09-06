using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
   public void LoadARScene()
   {
		  SceneManager.LoadScene("lungs");
   }
   public void ExitApp()
   {
		  Application.Quit();
		  Debug.Log("You have quit the app");
   }
   public void back_to_menu()
   {
		SceneManager.LoadScene("SampleScene");
   }
   public void next_Page()
   {
		SceneManager.LoadScene("SampleScene2");
   }
  public void LoadARScene_d()
   {
		  SceneManager.LoadScene("diaphragm");
   }
   public void LoadARScene_brain()
   {
		  SceneManager.LoadScene("brain");
   }
   public void LoadARScene_digest()
   {
		  SceneManager.LoadScene("digestive_system");
   }
    public void LoadARScene_lungs()
   {
		  SceneManager.LoadScene("lungs");
   }

   public void LoadARScene_h()
   {
		  SceneManager.LoadScene("heart");
   }
   
   public void LoadARScene_s()
   {
		  SceneManager.LoadScene("skeleton");
   }

   public void LoadARScene_k()
   {
		  SceneManager.LoadScene("kidney");
   }
   
   public void LoadARScene_liver()
   {
		  SceneManager.LoadScene("liver");
   }

   public void LoadARScene_fr()
   {
		  SceneManager.LoadScene("female_rep");
   }

   /*public void LoadARScene_mr()
   {
		  SceneManager.LoadScene("male_rep");
   }*/
   
   public void LoadARScene_ear()
   {
		  SceneManager.LoadScene("ear");
   }
   public void LoadARScene_eye()
   {
		  SceneManager.LoadScene("eye");
   }
   /*public void LoadARScene_spinal()
   {
		  SceneManager.LoadScene("spinalcord");
   }
   public void LoadARScene()
   {
		  SceneManager.LoadScene("diaphragm");
   }*/

   
   
}
