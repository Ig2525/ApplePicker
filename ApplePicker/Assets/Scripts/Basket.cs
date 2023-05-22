using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Basket : MonoBehaviour
{
   [Header("Set Dynamically")]
    public Text scoreGT;
    public GameObject scoreGO;




    // Start is called before the first frame update
    void Start()
    {  
        // Отримати ссилку на ігровий об'єкт ScoreCounter
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // Отримати компонент Text цього ігрового об'єкта 
        scoreGT = scoreGO.GetComponent<Text>();
        // Встановити початкове число очок рівним 0
        scoreGT.text="0";
    }


    // Update is called once per frame
    void Update()
    {
        //Переключення сприйняття позиціїї миші з 3D в 2D:
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z=-Camera.main.transform.position.z;
        Vector3 mousePos3D=Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
        //------------------------------------------------

    }

    //Ловимо яблука:
    private void OnCollisionEnter(Collision coll)
    {
        // Знайти яблука, що попали в цю корзину:
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            // Знищити яблуко
            Destroy(collidedWith);
            // Перетворити текст в scoreGT в цілое число
            int score = int.Parse(scoreGT.text);
            // Добавити очки за спімане яблуко
            score += 100;
            // Перетворити число очок назад в строку і вивести її на экран
            scoreGT.text = score.ToString();

            // Запам'ятати найбільше значення набраних очок
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
    //------------------------------------------------

}
