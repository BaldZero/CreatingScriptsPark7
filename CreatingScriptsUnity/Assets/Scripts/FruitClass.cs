using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass
{
    //Parent or base class
    public string color;
    // this is not an inherited constructor

    public FruitClass()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }
    //second constructor

    public FruitClass(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Construcctor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
