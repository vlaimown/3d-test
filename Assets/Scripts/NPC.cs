using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public int health; //создание переменной с глобальной областью видимости
    public int level;
    public float speed = 3.2f;
    Vector3 newPosition;
    void Start()
    {
        health = health + level; //прибавление текущего уровня к здоровью
        print(health);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
