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
        // �������� ������ �� ������� ��'��� ScoreCounter
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // �������� ��������� Text ����� �������� ��'���� 
        scoreGT = scoreGO.GetComponent<Text>();
        // ���������� ��������� ����� ���� ����� 0
        scoreGT.text="0";
    }


    // Update is called once per frame
    void Update()
    {
        //������������ ���������� �������� ���� � 3D � 2D:
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z=-Camera.main.transform.position.z;
        Vector3 mousePos3D=Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
        //------------------------------------------------

    }

    //������ ������:
    private void OnCollisionEnter(Collision coll)
    {
        // ������ ������, �� ������ � �� �������:
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            // ������� ������
            Destroy(collidedWith);
            // ����������� ����� � scoreGT � ����� �����
            int score = int.Parse(scoreGT.text);
            // �������� ���� �� ������ ������
            score += 100;
            // ����������� ����� ���� ����� � ������ � ������� �� �� �����
            scoreGT.text = score.ToString();

            // �����'����� �������� �������� �������� ����
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
    //------------------------------------------------

}
