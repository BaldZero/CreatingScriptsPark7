using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SomeClass : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Has signature of Add(int, int)
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    //Has signature of Add(string, string)
    public string Add(string str1, string str2)
    {
        return str1+ str2;
    }
}
