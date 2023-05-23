using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int count;
    public Text text;

    public void ButClick()
    {
        //if (Input.anyKey) SceneManager.LoadScene("SampleScene");
       SceneManager.LoadScene("SampleScene");
    }

    public void NewGame()
    {
      SceneManager.LoadScene("SampleScene");
    }

    // Quits the player when the user hits escape
    public void GameOwer()
    {
       // if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
       // {
            Application.Quit();    // закрыть приложение
       // }
    }
   
}
