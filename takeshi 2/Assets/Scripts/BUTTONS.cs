using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BUTTONS : MonoBehaviour
{
 public void startpress()
 {
SceneManager.LoadScene("Game"); 

 }
 public void exitpress()
 { 
Application.Quit();
 }
 public void backpress()
 {
SceneManager.LoadScene("main menu"); 
 }
}
