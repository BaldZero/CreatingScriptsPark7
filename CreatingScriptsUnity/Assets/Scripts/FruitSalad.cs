using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating the fruit");
        FruitClass myFruit = new FruitClass();
        Debug.Log("Creating the apple"); ;
        Apple myApple = new Apple();

        //Call fruitclass methods

        myFruit.SayHello();
        myFruit.Chop();
        //Call apple methods
        //apple has access to all public fruitclass methods
        myApple.SayHello();
        myApple.Chop();
        //now we illustrate inheritance with strings
        Debug.Log("Creating the fruit");
        myFruit = new FruitClass("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        //Call fruitclass methods again
        myFruit.SayHello();
        myFruit.Chop();

        //Call apple methods again
        myApple.SayHello();
        myApple.Chop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
