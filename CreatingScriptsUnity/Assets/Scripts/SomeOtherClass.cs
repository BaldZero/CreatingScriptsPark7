using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass myClass = new SomeClass();

        Debug.Log(myClass.Add(1, 2));
        Debug.Log((myClass.Add("Hello", "World")));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
