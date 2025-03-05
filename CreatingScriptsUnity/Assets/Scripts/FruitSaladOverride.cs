using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladOverride : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleOverride myApple = new AppleOverride();
        //the apple version of the methods override the fruit versions. both are also called since "base" keyword was also called

        myApple.SayHello();
        myApple.Chop();

        FruitOverride myFruit = new AppleOverride();
        myFruit.SayHello();
        myFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
