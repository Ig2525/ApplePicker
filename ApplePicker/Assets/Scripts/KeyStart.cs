using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyStart : MonoBehaviour
{


    void Update()
    {   
        //if(Input.anyKey) SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene("SampleScene");
    }
}
