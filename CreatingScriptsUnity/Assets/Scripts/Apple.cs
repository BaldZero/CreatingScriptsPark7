using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : FruitClass
{
    //this is the child or derived class
    //it calls the parent class before it even runs.
    public Apple()
    {
        //apple has access to tthe public variable color, which is from the fruitclass class.
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }
    //tthe second cconstructor specifies which parent construcctor will be called using base
    public Apple(string newColor) : base(newColor)
    {
        //the color is not set because the base cconstructor already set it
        Debug.Log("2nd Apple Constructor Called");
    }
            
}
