using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int count;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        text.text = count.ToString();
    }

    // Update is called once per frame
    public void ButClick()
    {
        //  count++;
        //text.text=count.ToString();
        //  Debug.Log(count);
        if (Input.anyKey) SceneManager.LoadScene("SampleScene");
        //SceneManager.LoadScene("SampleScene");
    }
}
