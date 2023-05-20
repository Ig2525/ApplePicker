using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Саме яблуко, яке буде падати з дерева
    public GameObject applePrefab;
    //Швидкість переміщення яблуні
    public float speed = 1f;
    //Обмеження по руху яблуні зліва і справа
    public float leftAndRightAdge = 10f;
    //імовірність зміни напрямку руху яблуні
    public float chanceToChangeDirections = 0.1f;
    //частота зміни...
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    private void DropApple()
    {
        GameObject apple =Instantiate(applePrefab);
        apple.transform.position= this.transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        pos.x += speed * Time.deltaTime;
        this.transform.position = pos;

        if(pos.x <- leftAndRightAdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightAdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if(Random.value<chanceToChangeDirections) 
        {
            speed *= -1;
        }
    }
}
