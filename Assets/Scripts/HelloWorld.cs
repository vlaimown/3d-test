using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string helloWorld;
    void Start()
    {
        print(helloWorld);
        print("Hello world! x2");
    }

    // Update is called once per frame
    void Update()
    {
        print("Message");
    }
}
